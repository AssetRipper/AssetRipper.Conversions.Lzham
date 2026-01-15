using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$zero_object@Ulzham_compress_params@@@utils@lzham@@YAXAEAUlzham_compress_params@@@Z")]
[DemangledName("void __cdecl lzham::utils::zero_object<struct lzham_compress_params>(struct lzham_compress_params &)")]
[CleanName("zero_object")]
internal static partial class zero_object_ccd6zn
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("struct lzham_compress_params &")] void* obj)
	{
		llvm_memset_p0_i64.Invoke(obj, 0, 48L, isVolatile: false);
	}
}
