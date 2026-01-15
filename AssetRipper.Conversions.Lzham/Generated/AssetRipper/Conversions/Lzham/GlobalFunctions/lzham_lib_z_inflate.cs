using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?lzham_lib_z_inflate@lzham@@YAHPEAUlzham_z_stream@@H@Z")]
[DemangledName("int __cdecl lzham::lzham_lib_z_inflate(struct lzham_z_stream *, int)")]
internal static partial class lzham_lib_z_inflate
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
			if (pStream == null || ((lzham_z_stream*)pStream)->state == null)
			{
				num2 = -2;
			}
			else
			{
				if (num == 1 || num == 3)
				{
					num = 2;
				}
				if (num != 0 && num != 2 && num != 4)
				{
					num2 = -2;
				}
				else
				{
					long num3 = (uint)((lzham_z_stream*)pStream)->avail_in;
					void* state = ((lzham_z_stream*)pStream)->state;
					void* ptr = state;
					if (((lzham_lzham_decompressor*)ptr)->m_z_last_status >= 3)
					{
						num2 = -3;
					}
					else if (((lzham_lzham_decompressor*)ptr)->m_z_has_flushed != 0 && num != 4)
					{
						num2 = -2;
					}
					else
					{
						((lzham_lzham_decompressor*)ptr)->m_z_has_flushed |= ((num == 4) ? 1 : 0);
						while (true)
						{
							localsPointer->field_0 = (uint)((lzham_z_stream*)pStream)->avail_in;
							localsPointer->field_1 = (uint)((lzham_z_stream*)pStream)->avail_out;
							int z_last_status = lzham_lib_decompress.Invoke(no_more_input_bytes_flag: (num == 4) ? 1 : 0, pOut_buf: ((lzham_z_stream*)pStream)->next_out, p: state, pIn_buf: ((lzham_z_stream*)pStream)->next_in, pIn_buf_size: &localsPointer->field_0, pOut_buf_size: &localsPointer->field_1);
							if (ExceptionInfo.Current != null)
							{
								return 0;
							}
							int num4 = (((lzham_lzham_decompressor*)ptr)->m_z_last_status = z_last_status);
							int num5 = (int)localsPointer->field_0;
							void** next_in = &((lzham_z_stream*)pStream)->next_in;
							*next_in = (byte*)(*next_in) + (uint)num5;
							int num6 = (int)localsPointer->field_0;
							((lzham_z_stream*)pStream)->avail_in -= num6;
							int num7 = (int)localsPointer->field_0;
							((lzham_z_stream*)pStream)->total_in += num7;
							((lzham_z_stream*)pStream)->adler = ((lzham_lzham_decompressor*)ptr)->m_decomp_adler32;
							int num8 = (int)localsPointer->field_1;
							void** next_out = &((lzham_z_stream*)pStream)->next_out;
							*next_out = (byte*)(*next_out) + (uint)num8;
							int num9 = (int)localsPointer->field_1;
							((lzham_z_stream*)pStream)->avail_out -= num9;
							int num10 = (int)localsPointer->field_1;
							((lzham_z_stream*)pStream)->total_out += num10;
							if (num4 >= 4)
							{
								num2 = ((num4 != 12) ? (-3) : 2);
								break;
							}
							if (num4 == 2 && num3 == 0L)
							{
								num2 = -5;
								break;
							}
							if (num == 4)
							{
								switch (num4)
								{
								default:
									continue;
								case 3:
									num2 = 1;
									break;
								case 1:
									num2 = -5;
									break;
								}
								break;
							}
							if (num4 != 3 && ((lzham_z_stream*)pStream)->avail_in != 0 && ((lzham_z_stream*)pStream)->avail_out != 0)
							{
								continue;
							}
							num2 = InstructionHelper.Select(num4 == 3, 1, 0);
							break;
						}
					}
				}
			}
			int result = num2;
			StackFrameList.Current.Clear(startFrame);
			return result;
		}
	}
}
