using AssetRipper.Conversions.Lzham.Helpers;
using AssetRipper.Conversions.Lzham.InlineArrays;

namespace AssetRipper.Conversions.Lzham.GlobalVariables;

[MangledName("?m_slot_tab2@CLZBase@lzham@@2PAEA")]
[DemangledName("public: static unsigned char *lzham::CLZBase::m_slot_tab2")]
internal static partial class m_slot_tab2
{
	public unsafe static InlineArray256_SByte* __pointer;

	public unsafe static InlineArray256_SByte Value
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

	unsafe static m_slot_tab2()
	{
		__pointer = unchecked((InlineArray256_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray256_SByte))));
		Value = InlineArrayHelper.Create<InlineArray256_SByte, byte>(new byte[256]
		{
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 40, 40, 40, 40,
			40, 40, 40, 40, 41, 41, 41, 41, 41, 41,
			41, 41, 42, 42, 42, 42, 42, 42, 42, 42,
			42, 42, 42, 42, 42, 42, 42, 42, 43, 43,
			43, 43, 43, 43, 43, 43, 43, 43, 43, 43,
			43, 43, 43, 43, 44, 44, 44, 44, 44, 44,
			44, 44, 44, 44, 44, 44, 44, 44, 44, 44,
			44, 44, 44, 44, 44, 44, 44, 44, 44, 44,
			44, 44, 44, 44, 44, 44, 45, 45, 45, 45,
			45, 45, 45, 45, 45, 45, 45, 45, 45, 45,
			45, 45, 45, 45, 45, 45, 45, 45, 45, 45,
			45, 45, 45, 45, 45, 45, 45, 45, 46, 46,
			46, 46, 46, 46, 46, 46, 46, 46, 46, 46,
			46, 46, 46, 46, 46, 46, 46, 46, 46, 46,
			46, 46, 46, 46, 46, 46, 46, 46, 46, 46,
			46, 46, 46, 46, 46, 46, 46, 46, 46, 46,
			46, 46, 46, 46, 46, 46, 46, 46, 46, 46,
			46, 46, 46, 46, 46, 46, 46, 46, 46, 46,
			46, 46, 47, 47, 47, 47, 47, 47, 47, 47,
			47, 47, 47, 47, 47, 47, 47, 47, 47, 47,
			47, 47, 47, 47, 47, 47, 47, 47, 47, 47,
			47, 47, 47, 47, 47, 47, 47, 47, 47, 47,
			47, 47, 47, 47, 47, 47, 47, 47, 47, 47,
			47, 47, 47, 47, 47, 47, 47, 47, 47, 47,
			47, 47, 47, 47, 47, 47
		});
	}
}
