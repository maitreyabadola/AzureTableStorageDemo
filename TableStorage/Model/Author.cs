using Microsoft.Azure.CosmosDB.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableStorage.Model
{
    class Author : TableEntity
    {
        public Author()
        {

        }

        public Author(string genere, string publisher)
        {
            this.PartitionKey = publisher;
            this.RowKey = genere;
        }

        public string Title { get; set; }

        public Double Price { get; set; }

        public int PublishedYear { get; set; }
    }
}
