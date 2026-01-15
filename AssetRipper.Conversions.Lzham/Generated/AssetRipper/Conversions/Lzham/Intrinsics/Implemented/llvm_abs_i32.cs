using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.Intrinsics.Implemented;

[MangledName("llvm.abs.i32")]
[DemangledName("llvm.abs.i32")]
internal static partial class llvm_abs_i32
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int Invoke(int parameter_0, bool parameter_1)
	{
		return NumericHelper.Abs(parameter_0);
	}
}
