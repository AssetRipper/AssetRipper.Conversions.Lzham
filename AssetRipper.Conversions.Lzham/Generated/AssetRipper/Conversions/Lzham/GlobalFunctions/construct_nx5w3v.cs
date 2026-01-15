using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$construct@Vadaptive_bit_model@lzham@@V12@@helpers@lzham@@YAPEAVadaptive_bit_model@1@PEAV21@AEBV21@@Z")]
[DemangledName("class lzham::adaptive_bit_model * __cdecl lzham::helpers::construct<class lzham::adaptive_bit_model, class lzham::adaptive_bit_model>(class lzham::adaptive_bit_model *, class lzham::adaptive_bit_model const &)")]
[CleanName("construct")]
internal static partial class construct_nx5w3v
{
	[return: NativeType("class lzham::adaptive_bit_model *")]
	public unsafe static void* Invoke([NativeType("class lzham::adaptive_bit_model *")] void* p, [NativeType("class lzham::adaptive_bit_model const &")] void* init)
	{
		adaptive_bit_model_Constructor_m7bfzj.Invoke(p, init);
		return p;
	}
}
