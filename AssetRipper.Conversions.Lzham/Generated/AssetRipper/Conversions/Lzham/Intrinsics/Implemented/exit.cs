using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.Intrinsics.Implemented;

internal static partial class exit
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Invoke(int exitCode)
	{
		IntrinsicFunctions.Exit(exitCode);
	}
}
