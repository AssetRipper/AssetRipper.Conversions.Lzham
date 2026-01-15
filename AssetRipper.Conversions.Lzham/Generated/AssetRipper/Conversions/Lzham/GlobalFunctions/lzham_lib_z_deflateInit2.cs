using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?lzham_lib_z_deflateInit2@lzham@@YAHPEAUlzham_z_stream@@HHHHH@Z")]
[DemangledName("int __cdecl lzham::lzham_lib_z_deflateInit2(struct lzham_z_stream *, int, int, int, int, int)")]
internal static partial class lzham_lib_z_deflateInit2
{
	private partial struct LocalVariables
	{
		public lzham_compress_params field_0;
	}

	[return: NativeType("int")]
	public unsafe static int Invoke([NativeType("struct lzham_z_stream *")] void* pStream, [NativeType("int")] int level, [NativeType("int")] int method, [NativeType("int")] int window_bits, [NativeType("int")] int mem_level, [NativeType("int")] int strategy)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = default(lzham_compress_params);
		int num = window_bits;
		int num2 = level;
		unchecked
		{
			int num3;
			if (pStream == null)
			{
				num3 = -2;
			}
			else if (mem_level < 1 || mem_level > 9)
			{
				num3 = -10000;
			}
			else if (method != 8 && method != 14)
			{
				num3 = -10000;
			}
			else
			{
				if (num2 == -1)
				{
					num2 = 9;
				}
				if (method == 8)
				{
					num = 15;
				}
				int num4 = 29;
				if (llvm_abs_i32.Invoke(num, parameter_1: true) < 15 || llvm_abs_i32.Invoke(num, parameter_1: true) > num4)
				{
					num3 = -10000;
				}
				else
				{
					zero_object_ccd6zn.Invoke(&localsPointer->field_0);
					localsPointer->field_0.m_struct_size = 48;
					localsPointer->field_0.m_level = 4;
					if (num2 <= 1)
					{
						localsPointer->field_0.m_level = 0;
					}
					else if (num2 <= 3)
					{
						localsPointer->field_0.m_level = 1;
					}
					else if (num2 <= 5)
					{
						localsPointer->field_0.m_level = 2;
					}
					else if (num2 <= 7)
					{
						localsPointer->field_0.m_level = 3;
					}
					if (num2 == 10)
					{
						localsPointer->field_0.m_compress_flags |= 2;
					}
					localsPointer->field_0.m_max_helper_threads = -1;
					int dict_size_log = llvm_abs_i32.Invoke(num, parameter_1: true);
					localsPointer->field_0.m_dict_size_log2 = dict_size_log;
					if (num > 0)
					{
						localsPointer->field_0.m_compress_flags |= 32;
					}
					((lzham_z_stream*)pStream)->data_type = 0;
					((lzham_z_stream*)pStream)->adler = 1;
					((lzham_z_stream*)pStream)->msg = null;
					((lzham_z_stream*)pStream)->reserved = 0;
					((lzham_z_stream*)pStream)->total_in = 0;
					((lzham_z_stream*)pStream)->total_out = 0;
					void* ptr = lzham_lib_compress_init.Invoke(&localsPointer->field_0);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
					void* ptr2 = ptr;
					if (ptr2 == null)
					{
						num3 = -10000;
					}
					else
					{
						((lzham_z_stream*)pStream)->state = ptr2;
						num3 = 0;
					}
				}
			}
			int result = num3;
			StackFrameList.Current.Clear(startFrame);
			return result;
		}
	}
}
