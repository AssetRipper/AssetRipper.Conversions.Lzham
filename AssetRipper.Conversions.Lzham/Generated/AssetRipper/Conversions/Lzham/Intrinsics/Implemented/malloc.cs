using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.Intrinsics.Implemented;

internal static partial class malloc
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static void* Invoke(long size)
	{
		return IntrinsicFunctions.Alloc(size);
	}
}
