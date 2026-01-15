using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;
using AssetRipper.Conversions.Lzham.Structures;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("?s_error_descs@?1??lzham_lib_z_error@lzham@@YAPEBDH@Z@4PAU<unnamed-type-s_error_descs>@?1??12@YAPEBDH@Z@A")]
[DemangledName("struct `char const * __cdecl lzham::lzham_lib_z_error(int)'::`2'::<unnamed-type-s_error_descs> *`char const * __cdecl lzham::lzham_lib_z_error(int)'::`2'::s_error_descs")]
internal static partial class s_error_descs
{
	public unsafe static InlineArray10_anon* __pointer;

	public unsafe static InlineArray10_anon Value
	{
		get
		{
			return *__pointer;
		}
		set
		{
			*__pointer = value;
		}
	}

	unsafe static s_error_descs()
	{
		__pointer = unchecked((InlineArray10_anon*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray10_anon))));
		Value = new InlineArrayBuilder<InlineArray10_anon, anon>
		{
			new anon
			{
				m_err = 0,
				m_pDesc = String_xaiud2.__pointer
			},
			new anon
			{
				m_err = 1,
				m_pDesc = String_hn7j2s.__pointer
			},
			new anon
			{
				m_err = 2,
				m_pDesc = String_a27e9k.__pointer
			},
			new anon
			{
				m_err = -1,
				m_pDesc = String_87eb53.__pointer
			},
			new anon
			{
				m_err = -2,
				m_pDesc = String_2bxz4p.__pointer
			},
			new anon
			{
				m_err = -3,
				m_pDesc = String_huh5mb.__pointer
			},
			new anon
			{
				m_err = -4,
				m_pDesc = String_38ab2g.__pointer
			},
			new anon
			{
				m_err = -5,
				m_pDesc = String_3w2xpy.__pointer
			},
			new anon
			{
				m_err = -6,
				m_pDesc = String_ba25s9.__pointer
			},
			new anon
			{
				m_err = -10000,
				m_pDesc = String_zybzvv.__pointer
			}
		};
	}
}
