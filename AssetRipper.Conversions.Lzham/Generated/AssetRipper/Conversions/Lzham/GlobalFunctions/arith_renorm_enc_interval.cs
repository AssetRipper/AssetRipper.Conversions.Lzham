using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?arith_renorm_enc_interval@symbol_codec@lzham@@QEAA_NXZ")]
[DemangledName("public: bool __cdecl lzham::symbol_codec::arith_renorm_enc_interval(void)")]
internal static partial class arith_renorm_enc_interval
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
			bool flag2;
			while (true)
			{
				lzham_vector* arith_output_buf = &((lzham_symbol_codec*)@this)->m_arith_output_buf;
				localsPointer->field_0 = (sbyte)((((lzham_symbol_codec*)@this)->m_arith_base >>> 24) & 0xFF);
				bool flag = try_push_back_myg3iw.Invoke(arith_output_buf, &localsPointer->field_0);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (((flag ? 1u : 0u) ^ 0xFFFFFFFFu) != 0)
				{
					flag2 = false;
					break;
				}
				((lzham_symbol_codec*)@this)->m_total_bits_written += 8;
				((lzham_symbol_codec*)@this)->m_arith_base <<= 8;
				if ((uint)(((lzham_symbol_codec*)@this)->m_arith_length <<= 8) >= 16777216u)
				{
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
