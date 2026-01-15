using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$zero_object@Ulzham_decompress_params@@@utils@lzham@@YAXAEAUlzham_decompress_params@@@Z")]
[DemangledName("void __cdecl lzham::utils::zero_object<struct lzham_decompress_params>(struct lzham_decompress_params &)")]
[CleanName("zero_object")]
internal static partial class zero_object_bebisp
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("struct lzham_decompress_params &")] void* obj)
	{
		llvm_memset_p0_i64.Invoke(obj, 0, 40L, isVolatile: false);
	}
}
