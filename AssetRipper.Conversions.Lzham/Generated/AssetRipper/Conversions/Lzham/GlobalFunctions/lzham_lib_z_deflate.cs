using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?lzham_lib_z_deflate@lzham@@YAHPEAUlzham_z_stream@@H@Z")]
[DemangledName("int __cdecl lzham::lzham_lib_z_deflate(struct lzham_z_stream *, int)")]
internal static partial class lzham_lib_z_deflate
{
	private partial struct LocalVariables
	{
		public long field_0;

		public long field_1;
	}

	[return: NativeType("int")]
	public unsafe static int Invoke([NativeType("struct lzham_z_stream *")] void* pStream, [NativeType("int")] int flush)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = 0L;
		localsPointer->field_1 = 0L;
		int num = flush;
		unchecked
		{
			int num2;
			if (pStream == null || ((lzham_z_stream*)pStream)->state == null || num < 0 || num > 4 || ((lzham_z_stream*)pStream)->next_out == null)
			{
				num2 = -2;
			}
			else if (((lzham_z_stream*)pStream)->avail_out == 0)
			{
				num2 = -5;
			}
			else
			{
				if (num == 1)
				{
					num = 2;
				}
				int num3 = 0;
				int total_in = ((lzham_z_stream*)pStream)->total_in;
				int total_out = ((lzham_z_stream*)pStream)->total_out;
				while (true)
				{
					localsPointer->field_0 = (uint)((lzham_z_stream*)pStream)->avail_in;
					localsPointer->field_1 = (uint)((lzham_z_stream*)pStream)->avail_out;
					void* state = ((lzham_z_stream*)pStream)->state;
					void* ptr = state;
					int num4 = lzham_lib_compress2.Invoke(flush_type: num, pOut_buf: ((lzham_z_stream*)pStream)->next_out, p: state, pIn_buf: ((lzham_z_stream*)pStream)->next_in, pIn_buf_size: &localsPointer->field_0, pOut_buf_size: &localsPointer->field_1);
					if (ExceptionInfo.Current != null)
					{
						return 0;
					}
					int num5 = num4;
					int num6 = (int)localsPointer->field_0;
					void** next_in = &((lzham_z_stream*)pStream)->next_in;
					*next_in = (byte*)(*next_in) + (uint)num6;
					int num7 = (int)localsPointer->field_0;
					((lzham_z_stream*)pStream)->avail_in -= num7;
					int num8 = (int)localsPointer->field_0;
					((lzham_z_stream*)pStream)->total_in += num8;
					int num9 = (int)localsPointer->field_1;
					void** next_out = &((lzham_z_stream*)pStream)->next_out;
					*next_out = (byte*)(*next_out) + (uint)num9;
					int num10 = (int)localsPointer->field_1;
					((lzham_z_stream*)pStream)->avail_out -= num10;
					int num11 = (int)localsPointer->field_1;
					((lzham_z_stream*)pStream)->total_out += num11;
					((lzham_z_stream*)pStream)->adler = Get_src_adler32.Invoke(&((lzham_lzham_compress_state*)ptr)->m_compressor);
					if (num5 >= 4)
					{
						num3 = -2;
					}
					else if (num5 == 3)
					{
						num3 = 1;
					}
					else if (((lzham_z_stream*)pStream)->avail_out != 0)
					{
						if (((lzham_z_stream*)pStream)->avail_in != 0 || num == 4)
						{
							continue;
						}
						if (num == 0 && ((lzham_z_stream*)pStream)->total_in == total_in && ((lzham_z_stream*)pStream)->total_out == total_out)
						{
							num2 = -5;
							break;
						}
					}
					num2 = num3;
					break;
				}
			}
			int result = num2;
			StackFrameList.Current.Clear(startFrame);
			return result;
		}
	}
}
