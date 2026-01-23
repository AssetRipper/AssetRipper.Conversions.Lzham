using AssetRipper.Conversions.Lzham.GlobalVariables;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?lzham_malloc@lzham@@YAPEAX_KPEA_K@Z")]
[DemangledName("void * __cdecl lzham::lzham_malloc(unsigned __int64, unsigned __int64 *)")]
internal static partial class lzham_malloc
{
	private partial struct LocalVariables
	{
		public long field_0;
	}

	[return: NativeType("void *")]
	public unsafe static void* Invoke([NativeType("unsigned __int64")] long size, [NativeType("unsigned __int64 *")] void* pActual_size)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = 0L;
		unchecked
		{
			long num = (size + 4L - 1L) & -4L;
			if (num == 0L)
			{
				num = 4L;
			}
			void* ptr;
			if ((ulong)num > 17179869184uL)
			{
				lzham_mem_error.Invoke(String_z2inc6.Pointer);
				ptr = null;
			}
			else
			{
				localsPointer->field_0 = num;
				void* value = g_pRealloc.Value;
				void* value2 = g_pUser_data.Value;
				void* ptr2 = ((delegate*<void*, long, long*, int, void*, void*>)value)(null, num, &localsPointer->field_0, 1, value2);
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
				void* ptr3 = ptr2;
				if (pActual_size != null)
				{
					*(long*)pActual_size = localsPointer->field_0;
				}
				if (ptr3 == null || (ulong)localsPointer->field_0 < (ulong)num)
				{
					lzham_mem_error.Invoke(String_tzftys.Pointer);
					ptr = null;
				}
				else
				{
					ptr = ptr3;
				}
			}
			void* result = ptr;
			StackFrameList.Current.Clear(startFrame);
			return result;
		}
	}
}
