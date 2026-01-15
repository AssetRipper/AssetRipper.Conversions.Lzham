using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??0adaptive_bit_model@lzham@@QEAA@M@Z")]
[DemangledName("public: __cdecl lzham::adaptive_bit_model::adaptive_bit_model(float)")]
[CleanName("adaptive_bit_model_Constructor")]
internal static partial class adaptive_bit_model_Constructor_h22wzd
{
	public unsafe static void* Invoke(void* @this, [NativeType("float")] float prob0)
	{
		Set_probability_0.Invoke(@this, prob0);
		return @this;
	}
}
