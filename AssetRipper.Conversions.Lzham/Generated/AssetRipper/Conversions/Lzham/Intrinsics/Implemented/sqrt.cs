using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.Intrinsics.Implemented;

internal static partial class sqrt
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double Invoke(double d)
	{
		return IntrinsicFunctions.Sqrt(d);
	}
}
