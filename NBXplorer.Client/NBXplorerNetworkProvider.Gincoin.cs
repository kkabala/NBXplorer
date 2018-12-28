using NBitcoin;
using System;
using System.Collections.Generic;
using System.Text;

namespace NBXplorer
{
    public partial class NBXplorerNetworkProvider
    {
		private void InitGincoin(NetworkType networkType)
		{
			Add(new NBXplorerNetwork(NBitcoin.Altcoins.Gincoin.Instance, networkType)
			{
				MinRPCVersion = 1000000
			});
		}

		public NBXplorerNetwork GetGINcoin()
		{
			return GetFromCryptoCode(NBitcoin.Altcoins.Gincoin.Instance.CryptoCode);
		}
	}
}
