using System;
using System.ComponentModel;
using System.Diagnostics;

namespace LibraryManagementSystem.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Form1 m_Form1;

            public Form1 Form1
            {
                [DebuggerHidden]
                get
                {
                    m_Form1 = Create__Instance__(m_Form1);
                    return m_Form1;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Form1))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Form1);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmBooks m_frmBooks;

            public frmBooks frmBooks
            {
                [DebuggerHidden]
                get
                {
                    m_frmBooks = Create__Instance__(m_frmBooks);
                    return m_frmBooks;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmBooks))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmBooks);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmBorrowBooks m_frmBorrowBooks;

            public frmBorrowBooks frmBorrowBooks
            {
                [DebuggerHidden]
                get
                {
                    m_frmBorrowBooks = Create__Instance__(m_frmBorrowBooks);
                    return m_frmBorrowBooks;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmBorrowBooks))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmBorrowBooks);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmBorrower m_frmBorrower;

            public frmBorrower frmBorrower
            {
                [DebuggerHidden]
                get
                {
                    m_frmBorrower = Create__Instance__(m_frmBorrower);
                    return m_frmBorrower;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmBorrower))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmBorrower);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmCategory m_frmCategory;

            public frmCategory frmCategory
            {
                [DebuggerHidden]
                get
                {
                    m_frmCategory = Create__Instance__(m_frmCategory);
                    return m_frmCategory;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmCategory))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmCategory);
                }
            }


            //[EditorBrowsable(EditorBrowsableState.Never)]
            //public frmLibraryCard m_frmLibraryCard;

            //public frmLibraryCard frmLibraryCard
            //{
            //    [DebuggerHidden]
            //    get
            //    {
            //        m_frmLibraryCard = Create__Instance__(m_frmLibraryCard);
            //        return m_frmLibraryCard;
            //    }
            //    [DebuggerHidden]
            //    set
            //    {
            //        if (ReferenceEquals(value, m_frmLibraryCard))
            //            return;
            //        if (value is not null)
            //            throw new ArgumentException("Property can only be set to Nothing");
            //        Dispose__Instance__(ref m_frmLibraryCard);
            //    }
            //}


            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmListBooks m_frmListBooks;

            public frmListBooks frmListBooks
            {
                [DebuggerHidden]
                get
                {
                    m_frmListBooks = Create__Instance__(m_frmListBooks);
                    return m_frmListBooks;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmListBooks))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmListBooks);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmListBorrower m_frmListBorrower;

            public frmListBorrower frmListBorrower
            {
                [DebuggerHidden]
                get
                {
                    m_frmListBorrower = Create__Instance__(m_frmListBorrower);
                    return m_frmListBorrower;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmListBorrower))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmListBorrower);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmLogin m_frmLogin;

            public frmLogin frmLogin
            {
                [DebuggerHidden]
                get
                {
                    m_frmLogin = Create__Instance__(m_frmLogin);
                    return m_frmLogin;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmLogin))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmLogin);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmOverdue m_frmOverdue;

            public frmOverdue frmOverdue
            {
                [DebuggerHidden]
                get
                {
                    m_frmOverdue = Create__Instance__(m_frmOverdue);
                    return m_frmOverdue;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmOverdue))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmOverdue);
                }
            }


            //[EditorBrowsable(EditorBrowsableState.Never)]
            //public frmReports m_frmReports;

            //public frmReports frmReports
            //{
            //    [DebuggerHidden]
            //    get
            //    {
            //        m_frmReports = Create__Instance__(m_frmReports);
            //        return m_frmReports;
            //    }
            //    [DebuggerHidden]
            //    set
            //    {
            //        if (ReferenceEquals(value, m_frmReports))
            //            return;
            //        if (value is not null)
            //            throw new ArgumentException("Property can only be set to Nothing");
            //        Dispose__Instance__(ref m_frmReports);
            //    }
            //}


            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmReturnBooks m_frmReturnBooks;

            public frmReturnBooks frmReturnBooks
            {
                [DebuggerHidden]
                get
                {
                    m_frmReturnBooks = Create__Instance__(m_frmReturnBooks);
                    return m_frmReturnBooks;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmReturnBooks))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmReturnBooks);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmUser m_frmUser;

            public frmUser frmUser
            {
                [DebuggerHidden]
                get
                {
                    m_frmUser = Create__Instance__(m_frmUser);
                    return m_frmUser;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmUser))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmUser);
                }
            }

        }


    }
}