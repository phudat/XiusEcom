using System;
using System.Collections.Generic;
using System.Text;

namespace XiusEcom.Orders
{
    public enum TransactionType
    {
        ConfirmOrder,
        StartProcessing,
        FinishOrder,
        CancelOrder
    }
}
