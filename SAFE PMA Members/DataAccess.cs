﻿using System.Data;
using Dapper;
using MySql.Data.MySqlClient;

namespace SAFE_PMA_Members
{
    public class DataAccess
    {
        public List<Member> MemberList(string lastName)
        {
            using var connection = new MySqlConnection
                (Helper.connVal("members"));
            //var output = connection.Query<Member>($"select * from members where lastName = '{lastName}'").ToList();
            var output = connection.Query<Member>($"CALL get_member_pre_list('{lastName}'").ToList();
            return output;
        }
    }
}

