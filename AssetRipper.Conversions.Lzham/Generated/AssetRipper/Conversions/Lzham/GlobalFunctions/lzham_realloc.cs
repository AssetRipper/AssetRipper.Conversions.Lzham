using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?lzham_realloc@lzham@@YAPEAXPEAX_KPEA_K_N@Z")]
[DemangledName("void * __cdecl lzham::lzham_realloc(void *, unsigned __int64, unsigned __int64 *, bool)")]
internal static partial class lzham_realloc
{
	private partial struct LocalVariables
	{
		public long field_0;
	}

	[return: NativeType("void *")]
	public unsafe static void* Invoke([NativeType("void *")] void* p, [NativeType("unsigned __int64")] long size, [NativeType("unsigned __int64 *")] void* pActual_size, [NativeType("bool")] bool movable)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = 0L;
		sbyte b = (movable ? ((sbyte)1) : ((sbyte)0));
		unchecked
		{
			void* ptr;
			if (((ulong)p & 0xFuL) != 0L)
			{
				lzham_mem_error.Invoke(String_b3sjk2.__pointer);
				ptr = null;
			}
			else if ((ulong)size > 17179869184uL)
			{
				lzham_mem_error.Invoke(String_z2inc6.__pointer);
				ptr = null;
			}
			else
			{
				localsPointer->field_0 = size;
				void* value = g_pRealloc.Value;
				void* value2 = g_pUser_data.Value;
				void* ptr2 = ((delegate*<void*, long, long*, int, void*, void*>)value)(p, size, &localsPointer->field_0, ((b & 1) == 1) ? 1 : 0, value2);
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
				void* ptr3 = ptr2;
				if (pActual_size != null)
				{
					*(long*)pActual_size = localsPointer->field_0;
				}
				ptr = ptr3;
			}
			void* result = ptr;
			StackFrameList.Current.Clear(startFrame);
			return result;
		}
	}
}
