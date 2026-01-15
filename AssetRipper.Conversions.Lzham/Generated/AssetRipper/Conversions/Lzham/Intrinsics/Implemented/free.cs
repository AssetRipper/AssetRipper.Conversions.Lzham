using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.Intrinsics.Implemented;

internal static partial class free
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static void Invoke(void* ptr)
	{
		IntrinsicFunctions.Free(ptr);
	}
}
