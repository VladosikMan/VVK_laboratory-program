using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClientLab.Client
{
    [Serializable]
    class Client
    {
        /// <summary>
        /// Имя клиента - уникальное в lowercase.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// группа, задаётся из списка ресурсов
        /// </summary>
        public string Group { get; set; }


        /// <summary>
        /// ip аддрес клиента
        /// </summary>
        public IPAddress Ip { get; set; }

        /// <summary>
        /// история прохождений лабораторных
        /// </summary>
        public List<HistoryRunLab> History { get; set; }

    }
}
