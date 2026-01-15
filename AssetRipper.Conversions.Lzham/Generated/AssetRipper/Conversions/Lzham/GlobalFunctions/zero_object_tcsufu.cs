using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.Intrinsics.Implemented;

namespace AssetRipper.Conversions.Lzham.GlobalFunctions;

[MangledName("??$zero_object@$$BY0BAC@I@utils@lzham@@YAXAEAY0BAC@I@Z")]
[DemangledName("void __cdecl lzham::utils::zero_object<unsigned int[258]>(unsigned int (&)[258])")]
[CleanName("zero_object")]
internal static partial class zero_object_tcsufu
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("unsigned int (&)[258]")] void* obj)
	{
		llvm_memset_p0_i64.Invoke(obj, 0, 1032L, isVolatile: false);
	}
}
