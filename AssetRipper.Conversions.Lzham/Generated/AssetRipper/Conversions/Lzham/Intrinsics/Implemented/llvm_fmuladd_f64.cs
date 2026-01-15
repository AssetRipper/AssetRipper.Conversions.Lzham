using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.Intrinsics.Implemented;

[MangledName("llvm.fmuladd.f64")]
[DemangledName("llvm.fmuladd.f64")]
internal static partial class llvm_fmuladd_f64
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double Invoke(double parameter_0, double parameter_1, double parameter_2)
	{
		return NumericHelper.FMulAdd(parameter_0, parameter_1, parameter_2);
	}
}
