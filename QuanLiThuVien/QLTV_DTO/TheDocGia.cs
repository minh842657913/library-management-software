﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DTO
{
    public class TheDocGia
    {
        string maThe;
        DocGia docGia;
        LoaiDocGia loaiDG;
        DateTime ngayLapThe;
        DateTime hanThe;

        public string MaThe
        {
            get
            {
                return maThe;
            }

            set
            {
                maThe = value;
            }
        }

        public DocGia DocGia
        {
            get
            {
                return docGia;
            }

            set
            {
                docGia = value;
            }
        }

        public LoaiDocGia LoaiDG
        {
            get
            {
                return loaiDG;
            }

            set
            {
                loaiDG = value;
            }
        }

        public DateTime NgayLapThe
        {
            get
            {
                return ngayLapThe;
            }

            set
            {
                ngayLapThe = value;
            }
        }

        public DateTime HanThe
        {
            get
            {
                return hanThe;
            }

            set
            {
                hanThe = value;
            }
        }
    }
}