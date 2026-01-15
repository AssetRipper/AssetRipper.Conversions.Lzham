using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?start_encoding@symbol_codec@lzham@@QEAA_NI@Z")]
[DemangledName("public: bool __cdecl lzham::symbol_codec::start_encoding(unsigned int)")]
internal static partial class start_encoding
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned int")] int expected_file_size)
	{
		unchecked
		{
			((lzham_symbol_codec*)@this)->m_mode = 1;
			((lzham_symbol_codec*)@this)->m_total_model_updates = 0;
			((lzham_symbol_codec*)@this)->m_total_bits_written = 0;
			bool flag = put_bits_init.Invoke(@this, expected_file_size);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag)
			{
				return false;
			}
			try_resize_tzyfr4.Invoke(&((lzham_symbol_codec*)@this)->m_output_syms, 0, grow_hint: false);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			arith_start_encoding.Invoke(@this);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			return true;
		}
	}
}
