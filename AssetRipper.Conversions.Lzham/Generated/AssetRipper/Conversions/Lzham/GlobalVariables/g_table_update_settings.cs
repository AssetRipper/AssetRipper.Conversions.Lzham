using System.Runtime.CompilerServices;
using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("?g_table_update_settings@lzham@@3PAUtable_update_settings@1@A")]
[DemangledName("struct lzham::table_update_settings *lzham::g_table_update_settings")]
internal static partial class g_table_update_settings
{
	[FixedAddressValueType]
	private static InlineArray20_lzham_table_update_settings __value;

	public unsafe static InlineArray20_lzham_table_update_settings* Pointer => unchecked((InlineArray20_lzham_table_update_settings*)Unsafe.AsPointer(ref __value));

	public static InlineArray20_lzham_table_update_settings Value
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

	unsafe static g_table_update_settings()
	{
		Value = new InlineArrayBuilder<InlineArray20_lzham_table_update_settings, lzham_table_update_settings>
		{
			new lzham_table_update_settings
			{
				m_max_update_interval = 4,
				m_slow_rate = 32
			},
			new lzham_table_update_settings
			{
				m_max_update_interval = 5,
				m_slow_rate = 33
			},
			new lzham_table_update_settings
			{
				m_max_update_interval = 6,
				m_slow_rate = 34
			},
			new lzham_table_update_settings
			{
				m_max_update_interval = 7,
				m_slow_rate = 35
			},
			new lzham_table_update_settings
			{
				m_max_update_interval = 8,
				m_slow_rate = 36
			},
			new lzham_table_update_settings
			{
				m_max_update_interval = 16,
				m_slow_rate = 48
			},
			new lzham_table_update_settings
			{
				m_max_update_interval = 32,
				m_slow_rate = 72
			},
			new lzham_table_update_settings
			{
				m_max_update_interval = 64,
				m_slow_rate = 64
			},
			new lzham_table_update_settings
			{
				m_max_update_interval = 98,
				m_slow_rate = 80
			},
			new lzham_table_update_settings
			{
				m_max_update_interval = 128,
				m_slow_rate = 96
			},
			new lzham_table_update_settings
			{
				m_max_update_interval = 192,
				m_slow_rate = 112
			},
			new lzham_table_update_settings
			{
				m_max_update_interval = 256,
				m_slow_rate = 128
			},
			new lzham_table_update_settings
			{
				m_max_update_interval = 512,
				m_slow_rate = 160
			},
			new lzham_table_update_settings
			{
				m_max_update_interval = 1024,
				m_slow_rate = 192
			},
			new lzham_table_update_settings
			{
				m_max_update_interval = 2048,
				m_slow_rate = 224
			},
			new lzham_table_update_settings
			{
				m_max_update_interval = 2048,
				m_slow_rate = 256
			},
			new lzham_table_update_settings
			{
				m_max_update_interval = 2048,
				m_slow_rate = 288
			},
			new lzham_table_update_settings
			{
				m_max_update_interval = 2048,
				m_slow_rate = 320
			},
			new lzham_table_update_settings
			{
				m_max_update_interval = 2048,
				m_slow_rate = 352
			},
			new lzham_table_update_settings
			{
				m_max_update_interval = 2048,
				m_slow_rate = 384
			}
		};
		PointerIndices.Register(Pointer);
	}
}
