using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.Intrinsics.Implemented;

internal static partial class fputs
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static int Invoke(void* str, void* file)
	{
		return IntrinsicFunctions.PutString(unchecked((sbyte*)str), file);
	}
}
