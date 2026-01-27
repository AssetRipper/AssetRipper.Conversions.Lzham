namespace AssetRipper.Conversions.Lzham.Tests;

public class Tests
{
	[Test]
	[Skip("Currently fails. Code is WIP")]
	public async Task TestCompression()
	{
		byte[] data = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
		byte[] compressed = Lzham.Compress(data);
		byte[] decompressed = Lzham.Decompress(compressed);
		await Assert.That(decompressed).IsEquivalentTo(data);
	}

	[Test]
	[Skip("Currently fails. Code is WIP")]
	public async Task TestZCompression()
	{
		byte[] data = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
		byte[] compressed = Lzham.ZCompress(data);
		byte[] decompressed = Lzham.ZDecompress(compressed);
		await Assert.That(decompressed).IsEquivalentTo(data);
	}
}