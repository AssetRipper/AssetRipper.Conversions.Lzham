using System.Runtime.InteropServices;
using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.Structures;

[StructLayout(LayoutKind.Explicit, Size = 88)]
[MangledName("struct.lzham_z_stream")]
public partial struct lzham_z_stream
{
	[FieldOffset(0)]
	public unsafe void* next_in;

	[FieldOffset(8)]
	public int avail_in;

	[FieldOffset(12)]
	public int total_in;

	[FieldOffset(16)]
	public unsafe void* next_out;

	[FieldOffset(24)]
	public int avail_out;

	[FieldOffset(28)]
	public int total_out;

	[FieldOffset(32)]
	public unsafe void* msg;

	[FieldOffset(40)]
	public unsafe void* state;

	[FieldOffset(48)]
	public unsafe void* zalloc;

	[FieldOffset(56)]
	public unsafe void* zfree;

	[FieldOffset(64)]
	public unsafe void* opaque;

	[FieldOffset(72)]
	public int data_type;

	[FieldOffset(76)]
	public int adler;

	[FieldOffset(80)]
	public int reserved;
}
