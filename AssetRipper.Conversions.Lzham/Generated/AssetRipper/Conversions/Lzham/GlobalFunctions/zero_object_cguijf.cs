using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$zero_object@$$BY1M@4I@utils@lzham@@YAXAEAY1M@4I@Z")]
[DemangledName("void __cdecl lzham::utils::zero_object<unsigned int[12][5]>(unsigned int (&)[12][5])")]
[CleanName("zero_object")]
internal static partial class zero_object_cguijf
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("unsigned int (&)[12][5]")] void* obj)
	{
		llvm_memset_p0_i64.Invoke(obj, 0, 240L, isVolatile: false);
	}
}
