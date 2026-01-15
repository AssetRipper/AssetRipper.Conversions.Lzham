using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("?get_cost@raw_quasi_adaptive_huffman_data_model@lzham@@QEBA_KI@Z")]
[DemangledName("public: unsigned __int64 __cdecl lzham::raw_quasi_adaptive_huffman_data_model::get_cost(unsigned int) const")]
[CleanName("Get_cost")]
internal static partial class Get_cost_dep2td
{
	[return: NativeType("unsigned __int64")]
	public unsafe static long Invoke(void* @this, [NativeType("unsigned int")] int sym)
	{
		return convert_to_scaled_bitcost.Invoke(unchecked((byte)(*(sbyte*)vector_unsigned_char_Operator_7ma9vz.Invoke(&((lzham_raw_quasi_adaptive_huffman_data_model*)@this)->m_code_sizes, sym))));
	}
}
