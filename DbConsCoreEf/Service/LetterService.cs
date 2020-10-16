using DbConsCoreEf.Data;
using DbConsCoreEf.Enginner;
using DbConsCoreEf.Entities;
using DbConsCoreEf.Entities.Letters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DbConsCoreEf.Service
{
    class LetterService
    {
        public A001 aa { get; set; }
        public B001 bb { get; set; }
        public C001 cc { get; set; }
        public D001 dd { get; set; }
        public E001 ee { get; set; }
        public F001 ff { get; set; }
        public G001 gg { get; set; }
        public H001 hh { get; set; }
        public I001 ii { get; set; }
        public J001 jj { get; set; }
        public K001 kk { get; set; }
        public L001 ll { get; set; }
        public M001 mm { get; set; }
        public N001 nn { get; set; }
        public O001 oo { get; set; }
        public P001 pp { get; set; }
        public Q001 qq { get; set; }
        public R001 rr { get; set; }
        public S001 ss { get; set; }
        public T001 tt { get; set; }
        public U001 uu { get; set; }
        public V001 vv { get; set; }
        public W001 ww { get; set; }
        public X001 xx { get; set; }
        public Y001 yy { get; set; }
        public Z001 zz { get; set; }
        private readonly ConsEfDbContext _context;
        private MsgEnginner _msg { get; set; }

        private WordListService _wordListService { get; set; }
        public LetterService()
        {
            _context = new ConsEfDbContext();
            _msg = new MsgEnginner();
        }

        public async Task OrderByLetter(string letter)
        {
            _wordListService = new WordListService();
            var words = await _wordListService.FindAllAsync();

            foreach (WordList word in words)
            {
                string w = word.Word.ToUpper();
                switch (letter.ToUpper())
                {
                    case "A":
                        if (w.StartsWith("A"))
                        {
                            var AExist = _context.A001s.Any(A => A.A == word.Word);
                            if (!AExist)
                            {
                                aa = new A001() { A = word.Word };
                                _context.A001s.Add(aa);
                                Console.WriteLine(_msg.Order() + " {0}", word.Word);
                                _context.SaveChanges();
                            }
                        }
                        break;
                    case "B":
                        if (w.StartsWith("B"))
                        {
                            var BExist = _context.B001s.Any(B => B.B == word.Word);
                            if (!BExist)
                            {
                                bb = new B001() { B = word.Word };
                                _context.B001s.Add(bb);
                                Console.WriteLine(_msg.Order() + " {0}", word.Word);
                                _context.SaveChanges();
                            }
                        }
                        break;
                    case "C":
                        if (w.StartsWith("C"))
                        {
                            var CExist = _context.C001s.Any(C => C.C == word.Word);
                            if (!CExist)
                            {
                                cc = new C001() { C = word.Word };
                                _context.C001s.Add(cc);
                                Console.WriteLine(_msg.Order() + " {0}", word.Word);
                                _context.SaveChanges();
                            }
                        }
                        break;
                    case "D":
                        if (w.StartsWith("D"))
                        {
                            var DExist = _context.D001s.Any(D => D.D == word.Word);
                            if (!DExist)
                            {
                                dd = new D001() { D = word.Word };
                                _context.D001s.Add(dd);
                                Console.WriteLine(_msg.Order() + " {0}", word.Word);
                                _context.SaveChanges();
                            }
                        }
                        break;
                    case "E":
                        if (w.StartsWith("E"))
                        {
                            var EExist = _context.E001s.Any(E => E.E == word.Word);
                            if (!EExist)
                            {
                                ee = new E001() { E = word.Word };
                                _context.E001s.Add(ee);
                                Console.WriteLine(_msg.Order() + " {0}", word.Word);
                                _context.SaveChanges();
                            }
                        }
                        break;
                    case "F":
                        if (w.StartsWith("F"))
                        {
                            var FExist = _context.F001s.Any(F => F.F == word.Word);
                            if (!FExist)
                            {
                                ff = new F001() { F = word.Word };
                                _context.F001s.Add(ff);
                                Console.WriteLine(_msg.Order() + " {0}", word.Word);
                                _context.SaveChanges();
                            }
                        }
                        break;
                    case "G":
                        if (w.StartsWith("G"))
                        {
                            var GExist = _context.G001s.Any(G => G.G == word.Word);
                            if (!GExist)
                            {
                                gg = new G001() { G = word.Word };
                                _context.G001s.Add(gg);
                                Console.WriteLine(_msg.Order() + " {0}", word.Word);
                                _context.SaveChanges();
                            }
                        }
                        break;
                    case "H":
                        if (w.StartsWith("H"))
                        {
                            var HExist = _context.H001s.Any(H => H.H == word.Word);
                            if (!HExist)
                            {
                                hh = new H001() { H = word.Word };
                                _context.H001s.Add(hh);
                                Console.WriteLine(_msg.Order() + " {0}", word.Word);
                                _context.SaveChanges();
                            }
                        }
                        break;
                    case "I":
                        if (w.StartsWith("I"))
                        {
                            var IExist = _context.I001s.Any(I => I.I == word.Word);
                            if (!IExist)
                            {
                                ii = new I001() { I = word.Word };
                                _context.I001s.Add(ii);
                                Console.WriteLine(_msg.Order() + " {0}", word.Word);
                                _context.SaveChanges();
                            }
                        }
                        break;
                    case "J":
                        if (w.StartsWith("J"))
                        {
                            var JExist = _context.J001s.Any(J => J.J == word.Word);
                            if (!JExist)
                            {
                                jj = new J001() { J = word.Word };
                                _context.J001s.Add(jj);
                                Console.WriteLine(_msg.Order() + " {0}", word.Word);
                                _context.SaveChanges();
                            }
                        }
                        break;
                    case "K":
                        if (w.StartsWith("K"))
                        {
                            var KExist = _context.K001s.Any(K => K.K == word.Word);
                            if (!KExist)
                            {
                                kk = new K001() { K = word.Word };
                                _context.K001s.Add(kk);
                                Console.WriteLine(_msg.Order() + " {0}", word.Word);
                                _context.SaveChanges();
                            }
                        }
                        break;
                    case "L":
                        if (w.StartsWith("L"))
                        {
                            var LExist = _context.L001s.Any(L => L.L == word.Word);
                            if (!LExist)
                            {
                                    ll = new L001() { L = word.Word };
                                    _context.L001s.Add(ll);
                                    Console.WriteLine(_msg.Order() + " {0}", word.Word);
                                    _context.SaveChanges();
                            }
                        }
                        break;
                    case "M":
                        if (w.StartsWith("M"))
                        {
                            var MExist = _context.M001s.Any(M => M.M == word.Word);
                            if (!MExist)
                            {
                                mm = new M001() { M = word.Word };
                                _context.M001s.Add(mm);
                                Console.WriteLine(_msg.Order() + " {0}", word.Word);
                                _context.SaveChanges();
                            }
                        }
                        break;
                    case "N":
                        if (w.StartsWith("N"))
                        {
                            var NExist = _context.N001s.Any(N => N.N == word.Word);
                            if (!NExist)
                            {
                                nn = new N001() { N = word.Word };
                                _context.N001s.Add(nn);
                                Console.WriteLine(_msg.Order() + " {0}", word.Word);
                                _context.SaveChanges();
                            }
                        }
                        break;
                    case "O":
                        if (w.StartsWith("O"))
                        {
                            var OExist = _context.O001s.Any(O => O.O == word.Word);
                            if (!OExist)
                            {
                                oo = new O001() { O = word.Word };
                                _context.O001s.Add(oo);
                                Console.WriteLine(_msg.Order() + " {0}", word.Word);
                                _context.SaveChanges();
                            }
                        }
                        break;
                    case "P":
                        if (w.StartsWith("P"))
                        {
                            var PExist = _context.P001s.Any(P => P.P == word.Word);
                            if (!PExist)
                            {
                                pp = new P001() { P = word.Word };
                                _context.P001s.Add(pp);
                                Console.WriteLine(_msg.Order() + " {0}", word.Word);
                                _context.SaveChanges();
                            }
                        }
                        break;
                    case "Q":
                        if (w.StartsWith("Q"))
                        {
                            var QExist = _context.Q001s.Any(Q => Q.Q == word.Word);
                            if (!QExist)
                            {
                                qq = new Q001() { Q = word.Word };
                                _context.Q001s.Add(qq);
                                Console.WriteLine(_msg.Order() + " {0}", word.Word);
                                _context.SaveChanges();
                            }
                        }
                        break;
                    case "R":
                        if (w.StartsWith("R"))
                        {
                            var RExist = _context.R001s.Any(R => R.R == word.Word);
                            if (!RExist)
                            {
                                rr = new R001() { R = word.Word };
                                _context.R001s.Add(rr);
                                Console.WriteLine(_msg.Order() + " {0}", word.Word);
                                _context.SaveChanges();
                            }
                        }
                        break;
                    case "S":
                        if (w.StartsWith("S"))
                        {
                            var SExist = _context.S001s.Any(S => S.S == word.Word);
                            if (!SExist)
                            {
                                ss = new S001() { S = word.Word };
                                _context.S001s.Add(ss);
                                Console.WriteLine(_msg.Order() + " {0}", word.Word);
                                _context.SaveChanges();
                            }
                        }
                        break;
                    case "T":
                        if (w.StartsWith("T"))
                        {
                            var TExist = _context.T001s.Any(T => T.T == word.Word);
                            if (!TExist)
                            {
                                tt = new T001() { T = word.Word };
                                _context.T001s.Add(tt);
                                Console.WriteLine(_msg.Order() + " {0}", word.Word);
                                _context.SaveChanges();
                            }
                        }
                        break;
                    case "U":
                        if (w.StartsWith("U"))
                        {
                            var UExist = _context.U001s.Any(U => U.U == word.Word);
                            if (!UExist)
                            {
                                uu = new U001() { U = word.Word };
                                _context.U001s.Add(uu);
                                Console.WriteLine(_msg.Order() + " {0}", word.Word);
                                _context.SaveChanges();
                            }
                        }
                        break;
                    case "V":
                        if (w.StartsWith("V"))
                        {
                            var VExist = _context.V001s.Any(V => V.V == word.Word);
                            if (!VExist)
                            {
                                vv = new V001() { V = word.Word };
                                _context.V001s.Add(vv);
                                Console.WriteLine(_msg.Order() + " {0}", word.Word);
                                _context.SaveChanges();
                            }
                        }
                        break;
                    case "W":
                        if (w.StartsWith("W"))
                        {
                            var WExist = _context.W001s.Any(W => W.W == word.Word);
                            if (!WExist)
                            {
                                ww = new W001() { W = word.Word };
                                _context.W001s.Add(ww);
                                Console.WriteLine(_msg.Order() + " {0}", word.Word);
                                _context.SaveChanges();
                            }
                        }
                        break;
                    case "X":
                        if (w.StartsWith("X"))
                        {
                            var XExist = _context.X001s.Any(X => X.X == word.Word);
                            if (!XExist)
                            {
                                xx = new X001() { X = word.Word };
                                _context.X001s.Add(xx);
                                Console.WriteLine(_msg.Order() + " {0}", word.Word);
                                _context.SaveChanges();
                            }
                        }
                        break;
                    case "Y":
                        if (w.StartsWith("Y"))
                        {
                            var YExist = _context.Y001s.Any(Y => Y.Y == word.Word);
                            if (!YExist)
                            {
                                yy = new Y001() { Y = word.Word };
                                _context.Y001s.Add(yy);
                                Console.WriteLine(_msg.Order() + " {0}", word.Word);
                                _context.SaveChanges();
                            }
                        }
                        break;
                    case "Z":
                        if (w.StartsWith("Z"))
                        {
                            var ZExist = _context.Z001s.Any(Z => Z.Z == word.Word);
                            if (!ZExist)
                            {
                                zz = new Z001() { Z = word.Word };
                                _context.Z001s.Add(zz);
                                Console.WriteLine(_msg.Order() + " {0}", word.Word);
                                _context.SaveChanges();
                            }
                        }
                        break;

                }








            }





        }


    }
}
