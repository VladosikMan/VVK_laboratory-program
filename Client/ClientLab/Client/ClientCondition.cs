using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientLab.Client
{
    //список состояний клиента при работе с сервером
    public enum ClientCondition
    {
        Unknown,

        [Display(Name = "Зарегистрирован")]
        Registered,

        [Display(Name = "Работает")]
        Work,

        [Display(Name = "Закончил работу")]
        Finished_Success,

        [Display(Name = "Катастрофа")]
        Finished_Fail,

        [Display(Name = "Вне сети")]
        Offline,
    }
}
