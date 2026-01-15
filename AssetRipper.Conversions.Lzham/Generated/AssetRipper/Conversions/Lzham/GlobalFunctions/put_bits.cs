using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?put_bits@symbol_codec@lzham@@QEAA_NII@Z")]
[DemangledName("public: bool __cdecl lzham::symbol_codec::put_bits(unsigned int, unsigned int)")]
internal static partial class put_bits
{
	private partial struct LocalVariables
	{
		public sbyte field_0;
	}

	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned int")] int bits, [NativeType("unsigned int")] int num_bits)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = 0;
		unchecked
		{
			bool flag;
			if (num_bits == 0)
			{
				flag = true;
			}
			else
			{
				((lzham_symbol_codec*)@this)->m_bit_count -= num_bits;
				long num = (long)((ulong)(uint)bits << (int)(uint)((lzham_symbol_codec*)@this)->m_bit_count);
				((lzham_symbol_codec*)@this)->m_bit_buf |= num;
				((lzham_symbol_codec*)@this)->m_total_bits_written += num_bits;
				while (true)
				{
					if (((lzham_symbol_codec*)@this)->m_bit_count <= 56)
					{
						lzham_vector* output_buf = &((lzham_symbol_codec*)@this)->m_output_buf;
						localsPointer->field_0 = (sbyte)(((lzham_symbol_codec*)@this)->m_bit_buf >>> 56);
						bool flag2 = try_push_back_myg3iw.Invoke(output_buf, &localsPointer->field_0);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (((flag2 ? 1u : 0u) ^ 0xFFFFFFFFu) != 0)
						{
							flag = false;
							break;
						}
						((lzham_symbol_codec*)@this)->m_bit_buf <<= 8;
						checked
						{
							unchecked((lzham_symbol_codec*)@this)->m_bit_count += 8;
							continue;
						}
					}
					flag = true;
					break;
				}
			}
			bool result = flag;
			StackFrameList.Current.Clear(startFrame);
			return result;
		}
	}
}
