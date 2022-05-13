using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daxonet.BintangPackaging.CommissionReport
{
    public class PaymentMethodScript
    {
        #region logic events

        public void BeforeSave(AutoCount.GeneralMaint.PaymentMethod.PaymentMethodBeforeSaveEventArgs e)
        {
        }

        public void AfterSave(AutoCount.GeneralMaint.PaymentMethod.PaymentMethodEventArgs e)
        {
        }

        public void BeforeDelete(AutoCount.GeneralMaint.PaymentMethod.PaymentMethodBeforeDeleteEventArgs e)
        {
        }

        public void AfterDelete(AutoCount.GeneralMaint.PaymentMethod.PaymentMethodEventArgs e)
        {
        }

        public void OnColumnChanged(AutoCount.GeneralMaint.PaymentMethod.PaymentMethodColumnChangedEventArgs e)
        {
        }

        #endregion

        #region form events

        public void OnFormInitialize(AutoCount.GeneralMaint.PaymentMethod.FormPaymentMethodEdit.FormInitializeEventArgs e)
        {
        }

        public void OnFormSave(AutoCount.GeneralMaint.PaymentMethod.FormPaymentMethodEdit.FormOnSaveEventArgs e)
        {
        }

        #endregion
    }
}
