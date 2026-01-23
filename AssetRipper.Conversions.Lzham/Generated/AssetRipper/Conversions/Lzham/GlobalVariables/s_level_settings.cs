using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("?s_level_settings@lzham@@3PAUcomp_settings@1@A")]
[DemangledName("struct lzham::comp_settings *lzham::s_level_settings")]
internal static partial class s_level_settings
{
	[FixedAddressValueType]
	private static InlineArray5_lzham_comp_settings __value;

	public unsafe static InlineArray5_lzham_comp_settings* Pointer => unchecked((InlineArray5_lzham_comp_settings*)Unsafe.AsPointer(ref __value));

	public static InlineArray5_lzham_comp_settings Value
	{
		get
		{
			return __value;
		}
		set
		{
			__value = value;
		}
	}

	unsafe static s_level_settings()
	{
		Value = new InlineArrayBuilder<InlineArray5_lzham_comp_settings, lzham_comp_settings>
		{
			new lzham_comp_settings
			{
				m_fast_bytes = 8,
				m_fast_adaptive_huffman_updating = 1,
				m_match_accel_max_matches_per_probe = 1,
				m_match_accel_max_probes = 2
			},
			new lzham_comp_settings
			{
				m_fast_bytes = 24,
				m_fast_adaptive_huffman_updating = 1,
				m_match_accel_max_matches_per_probe = 6,
				m_match_accel_max_probes = 12
			},
			new lzham_comp_settings
			{
				m_fast_bytes = 32,
				m_fast_adaptive_huffman_updating = 0,
				m_match_accel_max_matches_per_probe = -1,
				m_match_accel_max_probes = 16
			},
			new lzham_comp_settings
			{
				m_fast_bytes = 48,
				m_fast_adaptive_huffman_updating = 0,
				m_match_accel_max_matches_per_probe = -1,
				m_match_accel_max_probes = 32
			},
			new lzham_comp_settings
			{
				m_fast_bytes = 64,
				m_fast_adaptive_huffman_updating = 0,
				m_match_accel_max_matches_per_probe = -1,
				m_match_accel_max_probes = 128
			}
		};
		PointerIndices.Register(Pointer);
	}
}
