﻿using System;

namespace DatabaseExtension {

    public class DbColumnAttribute : Attribute {

        public DbColumnAttribute(string columnName) {
            this.ColumnName = columnName;
        }
        public DbColumnAttribute(string columnName, string dateFormat) : this(columnName) {
            this.DateFormat = DateFormat;
        }
        public string ColumnName {
            get;
        }

        public string DateFormat {
            get;
        }
    }
}