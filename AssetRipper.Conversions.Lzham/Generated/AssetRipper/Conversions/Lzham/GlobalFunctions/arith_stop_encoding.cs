using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?arith_stop_encoding@symbol_codec@lzham@@QEAA_NXZ")]
[DemangledName("public: bool __cdecl lzham::symbol_codec::arith_stop_encoding(void)")]
internal static partial class arith_stop_encoding
{
	private partial struct LocalVariables
	{
		public sbyte field_0;
	}

	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		localsPointer->field_0 = 0;
		unchecked
		{
			int arith_base = ((lzham_symbol_codec*)@this)->m_arith_base;
			if ((uint)((lzham_symbol_codec*)@this)->m_arith_length > 33554432u)
			{
				((lzham_symbol_codec*)@this)->m_arith_base += 16777216;
				((lzham_symbol_codec*)@this)->m_arith_length = 8388608;
			}
			else
			{
				((lzham_symbol_codec*)@this)->m_arith_base += 8388608;
				((lzham_symbol_codec*)@this)->m_arith_length = 32768;
			}
			if ((uint)arith_base > (uint)((lzham_symbol_codec*)@this)->m_arith_base)
			{
				arith_propagate_carry.Invoke(@this);
			}
			bool flag = arith_renorm_enc_interval.Invoke(@this);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			bool flag2;
			if (!flag)
			{
				flag2 = false;
			}
			else
			{
				while (true)
				{
					if ((uint)size_s5xcpk.Invoke(&((lzham_symbol_codec*)@this)->m_arith_output_buf) < 4u)
					{
						lzham_vector* arith_output_buf = &((lzham_symbol_codec*)@this)->m_arith_output_buf;
						localsPointer->field_0 = 0;
						bool flag3 = try_push_back_myg3iw.Invoke(arith_output_buf, &localsPointer->field_0);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (((flag3 ? 1u : 0u) ^ 0xFFFFFFFFu) != 0)
						{
							flag2 = false;
							break;
						}
						((lzham_symbol_codec*)@this)->m_total_bits_written += 8;
						continue;
					}
					flag2 = true;
					break;
				}
			}
			bool result = flag2;
			StackFrameList.Current.Clear(startFrame);
			return result;
		}
	}
}
