using AssetRipper.Conversions.Lzham.Helpers;

namespace AssetRipper.Conversions.Lzham.Enumerations;

[MangledName(".?AW4lzham_compress_flags@@")]
[DemangledName("enum lzham_compress_flags")]
public enum lzham_compress_flags
{
	LZHAM_COMP_FLAG_EXTREME_PARSING = 2,
	LZHAM_COMP_FLAG_DETERMINISTIC_PARSING = 4,
	LZHAM_COMP_FLAG_TRADEOFF_DECOMPRESSION_RATE_FOR_COMP_RATIO = 0x10,
	LZHAM_COMP_FLAG_WRITE_ZLIB_STREAM = 0x20
}
