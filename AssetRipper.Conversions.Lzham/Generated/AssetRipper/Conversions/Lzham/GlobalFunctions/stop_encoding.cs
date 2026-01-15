using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?stop_encoding@symbol_codec@lzham@@QEAA_N_N@Z")]
[DemangledName("public: bool __cdecl lzham::symbol_codec::stop_encoding(bool)")]
internal static partial class stop_encoding
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("bool")] bool support_arith)
	{
		if (((support_arith ? 1u : 0u) & 1u) == 1)
		{
			bool flag = arith_stop_encoding.Invoke(@this);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag)
			{
				return false;
			}
		}
		bool flag2 = assemble_output_buf.Invoke(@this);
		if (ExceptionInfo.Current != null)
		{
			return false;
		}
		if (!flag2)
		{
			return false;
		}
		unchecked((lzham_symbol_codec*)@this)->m_mode = 0;
		return true;
	}
}
