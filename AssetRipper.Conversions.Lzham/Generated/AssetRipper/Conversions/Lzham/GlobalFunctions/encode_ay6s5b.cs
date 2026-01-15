using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?encode@symbol_codec@lzham@@QEAA_NIAEAVadaptive_bit_model@2@_N@Z")]
[DemangledName("public: bool __cdecl lzham::symbol_codec::encode(unsigned int, class lzham::adaptive_bit_model &, bool)")]
[CleanName("encode")]
internal static partial class encode_ay6s5b
{
	private partial struct LocalVariables
	{
		public lzham_sym_freq field_0;
	}

	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned int")] int bit, [NativeType("class lzham::adaptive_bit_model &")] void* model, [NativeType("bool")] bool update_model)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = default(lzham_sym_freq);
		sbyte b = (update_model ? ((sbyte)1) : ((sbyte)0));
		bool flag2;
		unchecked
		{
			((lzham_symbol_codec*)@this)->m_arith_total_bits++;
			localsPointer->field_0.m_freq = bit;
			localsPointer->field_0.m_left = -1;
			short bit_0_prob = ((lzham_adaptive_bit_model*)model)->m_bit_0_prob;
			localsPointer->field_0.m_right = bit_0_prob;
			bool flag = try_push_back_wrcwgy.Invoke(&((lzham_symbol_codec*)@this)->m_output_syms, &localsPointer->field_0);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag)
			{
				flag2 = false;
			}
			else
			{
				int num = (ushort)((lzham_adaptive_bit_model*)model)->m_bit_0_prob * (((lzham_symbol_codec*)@this)->m_arith_length >>> 11);
				if (bit == 0)
				{
					if ((b & 1) == 1)
					{
						int num2 = 2048 - (ushort)((lzham_adaptive_bit_model*)model)->m_bit_0_prob >>> 5;
						short* bit_0_prob2 = &((lzham_adaptive_bit_model*)model)->m_bit_0_prob;
						*bit_0_prob2 = (short)((ushort)(*bit_0_prob2) + num2);
					}
					((lzham_symbol_codec*)@this)->m_arith_length = num;
				}
				else
				{
					if ((b & 1) == 1)
					{
						int num3 = (ushort)((lzham_adaptive_bit_model*)model)->m_bit_0_prob >> 5;
						short* bit_0_prob3 = &((lzham_adaptive_bit_model*)model)->m_bit_0_prob;
						*bit_0_prob3 = (short)checked(unchecked((ushort)(*bit_0_prob3)) - num3);
					}
					int arith_base = ((lzham_symbol_codec*)@this)->m_arith_base;
					((lzham_symbol_codec*)@this)->m_arith_base += num;
					((lzham_symbol_codec*)@this)->m_arith_length -= num;
					if ((uint)arith_base > (uint)((lzham_symbol_codec*)@this)->m_arith_base)
					{
						arith_propagate_carry.Invoke(@this);
					}
				}
				if ((uint)((lzham_symbol_codec*)@this)->m_arith_length < 16777216u)
				{
					bool flag3 = arith_renorm_enc_interval.Invoke(@this);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					if (!flag3)
					{
						flag2 = false;
						goto IL_01d6;
					}
				}
				flag2 = true;
			}
			goto IL_01d6;
		}
		IL_01d6:
		bool result = flag2;
		StackFrameList.Current.Clear(startFrame);
		return result;
	}
}
