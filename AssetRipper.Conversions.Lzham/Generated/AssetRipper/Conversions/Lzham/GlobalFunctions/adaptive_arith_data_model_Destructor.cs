using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??1adaptive_arith_data_model@lzham@@QEAA@XZ")]
[DemangledName("public: __cdecl lzham::adaptive_arith_data_model::~adaptive_arith_data_model(void)")]
internal static partial class adaptive_arith_data_model_Destructor
{
	public unsafe static void Invoke(void* @this)
	{
		vector_class_lzham_adaptive_bit_model_Destructor.Invoke(&unchecked((lzham_adaptive_arith_data_model*)@this)->m_probs);
	}
}
