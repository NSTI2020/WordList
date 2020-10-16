using System;
using System.Collections.Generic;
using System.Text;
using DbConsCoreEf.Entities;
using DbConsCoreEf.Entities.Letters;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;


namespace DbConsCoreEf.Data
{
    class ConsEfDbContext : DbContext
    {
        public DbSet<Alphabet_PtBr> alphPtBrs { get; set; }
        public DbSet<WordList> wordLists { get; set; }
        public DbSet<A001> A001s { get; set; }//1
        public DbSet<B001> B001s { get; set; }//2
        public DbSet<C001> C001s { get; set; }//3
        public DbSet<D001> D001s { get; set; }//4
        public DbSet<E001> E001s { get; set; }//5
        public DbSet<F001> F001s { get; set; }//6
        public DbSet<G001> G001s { get; set; }//7
        public DbSet<H001> H001s { get; set; }//8
        public DbSet<I001> I001s { get; set; }//9
        public DbSet<J001> J001s { get; set; }//10
        public DbSet<K001> K001s { get; set; }//11
        public DbSet<L001> L001s { get; set; }//12
        public DbSet<M001> M001s { get; set; }//13
        public DbSet<N001> N001s { get; set; }//14
        public DbSet<O001> O001s { get; set; }//15
        public DbSet<P001> P001s { get; set; }//16
        public DbSet<Q001> Q001s { get; set; }//17
        public DbSet<R001> R001s { get; set; }//18
        public DbSet<S001> S001s { get; set; }//19
        public DbSet<T001> T001s { get; set; }//20
        public DbSet<U001> U001s { get; set; }//21
        public DbSet<V001> V001s { get; set; }//22
        public DbSet<W001> W001s { get; set; }//23
        public DbSet<X001> X001s { get; set; }//24
        public DbSet<Y001> Y001s { get; set; }//25
        public DbSet<Z001> Z001s { get; set; }//26

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;userid=developer;password=1234567;database=DbConsEf");
        }
    }
}
