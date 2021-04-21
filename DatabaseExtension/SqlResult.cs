﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseExtension {
    public class SqlResult {
        public SqlResult(System.Data.IDataReader dr) {
            this.Columns = new SqlResultColumnCollection(dr, this);
            this.Rows = new SqlResultRowCollection(dr, this);
        }
        public SqlResultColumnCollection Columns {
            get;
        }
        public SqlResultRowCollection Rows {
            get;
        }
    }
}
