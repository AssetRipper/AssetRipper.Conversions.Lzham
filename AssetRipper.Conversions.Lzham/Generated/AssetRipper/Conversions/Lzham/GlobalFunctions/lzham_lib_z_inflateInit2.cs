using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?lzham_lib_z_inflateInit2@lzham@@YAHPEAUlzham_z_stream@@H@Z")]
[DemangledName("int __cdecl lzham::lzham_lib_z_inflateInit2(struct lzham_z_stream *, int)")]
internal static partial class lzham_lib_z_inflateInit2
{
	private partial struct LocalVariables
	{
		public lzham_decompress_params field_0;
	}

	[return: NativeType("int")]
	public unsafe static int Invoke([NativeType("struct lzham_z_stream *")] void* pStream, [NativeType("int")] int window_bits)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = default(lzham_decompress_params);
		int num = window_bits;
		unchecked
		{
			int num2;
			if (pStream == null)
			{
				num2 = -2;
			}
			else if (llvm_abs_i32.Invoke(num, parameter_1: true) > 29)
			{
				num2 = -10000;
			}
			else
			{
				if (llvm_abs_i32.Invoke(num, parameter_1: true) < 15)
				{
					num = InstructionHelper.Select(num < 0, -15, 15);
				}
				zero_object_bebisp.Invoke(&localsPointer->field_0);
				localsPointer->field_0.m_struct_size = 40;
				int dict_size_log = llvm_abs_i32.Invoke(num, parameter_1: true);
				localsPointer->field_0.m_dict_size_log2 = dict_size_log;
				localsPointer->field_0.m_decompress_flags = 2;
				if (num > 0)
				{
					localsPointer->field_0.m_decompress_flags |= 4;
				}
				void* ptr = lzham_lib_decompress_init.Invoke(&localsPointer->field_0);
				if (ExceptionInfo.Current != null)
				{
					return 0;
				}
				void* ptr2 = ptr;
				if (ptr2 == null)
				{
					num2 = -4;
				}
				else
				{
					((lzham_z_stream*)pStream)->state = ptr2;
					((lzham_z_stream*)pStream)->data_type = 0;
					((lzham_z_stream*)pStream)->adler = 1;
					((lzham_z_stream*)pStream)->msg = null;
					((lzham_z_stream*)pStream)->total_in = 0;
					((lzham_z_stream*)pStream)->total_out = 0;
					((lzham_z_stream*)pStream)->reserved = 0;
					num2 = 0;
				}
			}
			int result = num2;
			StackFrameList.Current.Clear(startFrame);
			return result;
		}
	}
}
