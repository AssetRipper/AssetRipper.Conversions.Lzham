using System.Runtime.InteropServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[MangledName("struct.anon")]
public partial struct anon
{
	[FieldOffset(0)]
	public int m_err;

	[FieldOffset(8)]
	public unsafe void* m_pDesc;
}
