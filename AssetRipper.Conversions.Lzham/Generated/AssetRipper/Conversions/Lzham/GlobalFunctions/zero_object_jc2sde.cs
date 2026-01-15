using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$zero_object@$$BY0CD@I@utils@lzham@@YAXAEAY0CD@I@Z")]
[DemangledName("void __cdecl lzham::utils::zero_object<unsigned int[35]>(unsigned int (&)[35])")]
[CleanName("zero_object")]
internal static partial class zero_object_jc2sde
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("unsigned int (&)[35]")] void* obj)
	{
		llvm_memset_p0_i64.Invoke(obj, 0, 140L, isVolatile: false);
	}
}
