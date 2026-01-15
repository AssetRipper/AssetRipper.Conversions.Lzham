using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.Intrinsics.Implemented;

internal static partial class clock
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int Invoke()
	{
		return IntrinsicFunctions.Clock();
	}
}
