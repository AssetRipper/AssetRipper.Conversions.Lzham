using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?lzham_lib_z_uncompress@lzham@@YAHPEAEPEAKPEBEK@Z")]
[DemangledName("int __cdecl lzham::lzham_lib_z_uncompress(unsigned char *, unsigned long *, unsigned char const *, unsigned long)")]
internal static partial class lzham_lib_z_uncompress
{
	private partial struct LocalVariables
	{
		public lzham_z_stream field_0;
	}

	[return: NativeType("int")]
	public unsafe static int Invoke([NativeType("unsigned char *")] void* pDest, [NativeType("unsigned long *")] void* pDest_len, [NativeType("unsigned char const *")] void* pSource, [NativeType("unsigned long")] int source_len)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = default(lzham_z_stream);
		llvm_memset_p0_i64.Invoke(&localsPointer->field_0, 0, 88L, isVolatile: false);
		unchecked
		{
			int num;
			if ((uint)(source_len | *(int*)pDest_len) > uint.MaxValue)
			{
				num = -10000;
			}
			else
			{
				localsPointer->field_0.next_in = pSource;
				localsPointer->field_0.avail_in = source_len;
				localsPointer->field_0.next_out = pDest;
				int avail_out = *(int*)pDest_len;
				localsPointer->field_0.avail_out = avail_out;
				int num2 = lzham_lib_z_inflateInit.Invoke(&localsPointer->field_0);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				int num3 = num2;
				if (num3 != 0)
				{
					num = num3;
				}
				else
				{
					int num4 = lzham_lib_z_inflate.Invoke(&localsPointer->field_0, 4);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
					num3 = num4;
					if (num3 != 1)
					{
						lzham_lib_z_inflateEnd.Invoke(&localsPointer->field_0);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						num = ((num3 != -5 || localsPointer->field_0.avail_in != 0) ? num3 : (-3));
					}
					else
					{
						*(int*)pDest_len = localsPointer->field_0.total_out;
						int num5 = lzham_lib_z_inflateEnd.Invoke(&localsPointer->field_0);
						if (ExceptionInfo.Current != null)
						{
							return 0;
						}
						num = num5;
					}
				}
			}
			int result = num;
			StackFrameList.Current.Clear(startFrame);
			return result;
		}
	}
}
