﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RDotNet.Internals {
	
	
	internal partial class DelegateNativeMethods {
		
		[System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		delegate bool _Rf_isLanguage(System.IntPtr sexp);
		
		public bool Rf_isLanguage(System.IntPtr sexp) {
			var function = this.dll.GetFunction<_Rf_isLanguage>("Rf_isLanguage");
			return function(  sexp);
		}
		
		[System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		delegate bool _Rf_isFunction(System.IntPtr sexp);
		
		public bool Rf_isFunction(System.IntPtr sexp) {
			var function = this.dll.GetFunction<_Rf_isFunction>("Rf_isFunction");
			return function(  sexp);
		}
		
		[System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		delegate System.IntPtr _R_lsInternal(System.IntPtr environment, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)] bool all);
		
		public System.IntPtr R_lsInternal(System.IntPtr environment, bool all) {
			var function = this.dll.GetFunction<_R_lsInternal>("R_lsInternal");
			return function(  environment,   all);
		}
		
		[System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		delegate System.IntPtr _Rf_applyClosure(System.IntPtr call, System.IntPtr value, System.IntPtr arguments, System.IntPtr environment, System.IntPtr suppliedEnvironment);
		
		public System.IntPtr Rf_applyClosure(System.IntPtr call, System.IntPtr value, System.IntPtr arguments, System.IntPtr environment, System.IntPtr suppliedEnvironment) {
			var function = this.dll.GetFunction<_Rf_applyClosure>("Rf_applyClosure");
			return function(  call,   value,   arguments,   environment,   suppliedEnvironment);
		}
		
		[System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		delegate System.IntPtr _Rf_VectorToPairList(System.IntPtr sexp);
		
		public System.IntPtr Rf_VectorToPairList(System.IntPtr sexp) {
			var function = this.dll.GetFunction<_Rf_VectorToPairList>("Rf_VectorToPairList");
			return function(  sexp);
		}
		
		[System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		delegate System.IntPtr _Rf_allocSExp(RDotNet.Internals.SymbolicExpressionType type);
		
		public System.IntPtr Rf_allocSExp(RDotNet.Internals.SymbolicExpressionType type) {
			var function = this.dll.GetFunction<_Rf_allocSExp>("Rf_allocSExp");
			return function(  type);
		}
		
		[System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		delegate int _Rf_initEmbeddedR(int argc, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPArray, ArraySubType=System.Runtime.InteropServices.UnmanagedType.LPStr)] string[] argv);
		
		public int Rf_initEmbeddedR(int argc, string[] argv) {
			var function = this.dll.GetFunction<_Rf_initEmbeddedR>("Rf_initEmbeddedR");
			return function(  argc,   argv);
		}
		
		[System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		delegate void _Rf_endEmbeddedR(int fatal);
		
		public void Rf_endEmbeddedR(int fatal) {
			var function = this.dll.GetFunction<_Rf_endEmbeddedR>("Rf_endEmbeddedR");
			function(  fatal);
		}
		
		[System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		delegate System.IntPtr _Rf_protect(System.IntPtr sexp);
		
		public System.IntPtr Rf_protect(System.IntPtr sexp) {
			var function = this.dll.GetFunction<_Rf_protect>("Rf_protect");
			return function(  sexp);
		}
		
		[System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		delegate void _Rf_unprotect(int count);
		
		public void Rf_unprotect(int count) {
			var function = this.dll.GetFunction<_Rf_unprotect>("Rf_unprotect");
			function(  count);
		}
		
		[System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		delegate void _Rf_unprotect_ptr(System.IntPtr sexp);
		
		public void Rf_unprotect_ptr(System.IntPtr sexp) {
			var function = this.dll.GetFunction<_Rf_unprotect_ptr>("Rf_unprotect_ptr");
			function(  sexp);
		}
		
		[System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		delegate System.IntPtr _Rf_install([System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string s);
		
		public System.IntPtr Rf_install(string s) {
			var function = this.dll.GetFunction<_Rf_install>("Rf_install");
			return function(  s);
		}
		
		[System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		delegate System.IntPtr _Rf_mkString([System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string s);
		
		public System.IntPtr Rf_mkString(string s) {
			var function = this.dll.GetFunction<_Rf_mkString>("Rf_mkString");
			return function(  s);
		}
		
		[System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		delegate System.IntPtr _Rf_mkChar([System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string s);
		
		public System.IntPtr Rf_mkChar(string s) {
			var function = this.dll.GetFunction<_Rf_mkChar>("Rf_mkChar");
			return function(  s);
		}
		
		[System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		delegate System.IntPtr _Rf_allocVector(RDotNet.Internals.SymbolicExpressionType type, int length);
		
		public System.IntPtr Rf_allocVector(RDotNet.Internals.SymbolicExpressionType type, int length) {
			var function = this.dll.GetFunction<_Rf_allocVector>("Rf_allocVector");
			return function(  type,   length);
		}
		
		[System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		delegate System.IntPtr _Rf_coerceVector(System.IntPtr sexp, RDotNet.Internals.SymbolicExpressionType type);
		
		public System.IntPtr Rf_coerceVector(System.IntPtr sexp, RDotNet.Internals.SymbolicExpressionType type) {
			var function = this.dll.GetFunction<_Rf_coerceVector>("Rf_coerceVector");
			return function(  sexp,   type);
		}
		
		[System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		delegate bool _Rf_isVector(System.IntPtr sexp);
		
		public bool Rf_isVector(System.IntPtr sexp) {
			var function = this.dll.GetFunction<_Rf_isVector>("Rf_isVector");
			return function(  sexp);
		}
		
		[System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		delegate int _Rf_length(System.IntPtr sexp);
		
		public int Rf_length(System.IntPtr sexp) {
			var function = this.dll.GetFunction<_Rf_length>("Rf_length");
			return function(  sexp);
		}
		
		[System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		delegate System.IntPtr _Rf_allocMatrix(RDotNet.Internals.SymbolicExpressionType type, int rowCount, int columnCount);
		
		public System.IntPtr Rf_allocMatrix(RDotNet.Internals.SymbolicExpressionType type, int rowCount, int columnCount) {
			var function = this.dll.GetFunction<_Rf_allocMatrix>("Rf_allocMatrix");
			return function(  type,   rowCount,   columnCount);
		}
		
		[System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		delegate bool _Rf_isMatrix(System.IntPtr sexp);
		
		public bool Rf_isMatrix(System.IntPtr sexp) {
			var function = this.dll.GetFunction<_Rf_isMatrix>("Rf_isMatrix");
			return function(  sexp);
		}
		
		[System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		delegate int _Rf_nrows(System.IntPtr sexp);
		
		public int Rf_nrows(System.IntPtr sexp) {
			var function = this.dll.GetFunction<_Rf_nrows>("Rf_nrows");
			return function(  sexp);
		}
		
		[System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		delegate int _Rf_ncols(System.IntPtr sexp);
		
		public int Rf_ncols(System.IntPtr sexp) {
			var function = this.dll.GetFunction<_Rf_ncols>("Rf_ncols");
			return function(  sexp);
		}
		
		[System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		delegate System.IntPtr _Rf_allocList(int length);
		
		public System.IntPtr Rf_allocList(int length) {
			var function = this.dll.GetFunction<_Rf_allocList>("Rf_allocList");
			return function(  length);
		}
		
		[System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		delegate bool _Rf_isList(System.IntPtr sexp);
		
		public bool Rf_isList(System.IntPtr sexp) {
			var function = this.dll.GetFunction<_Rf_isList>("Rf_isList");
			return function(  sexp);
		}
		
		[System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		delegate System.IntPtr _Rf_eval(System.IntPtr statement, System.IntPtr environment);
		
		public System.IntPtr Rf_eval(System.IntPtr statement, System.IntPtr environment) {
			var function = this.dll.GetFunction<_Rf_eval>("Rf_eval");
			return function(  statement,   environment);
		}
		
		[System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		delegate System.IntPtr _R_tryEval(System.IntPtr statement, System.IntPtr environment, out bool errorOccurred);
		
		public System.IntPtr R_tryEval(System.IntPtr statement, System.IntPtr environment, out bool errorOccurred) {
			var function = this.dll.GetFunction<_R_tryEval>("R_tryEval");
			return function(  statement,   environment, out   errorOccurred);
		}
		
		[System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		delegate System.IntPtr _R_ParseVector(System.IntPtr statement, int statementCount, out RDotNet.Internals.ParseStatus status, System.IntPtr _);
		
		public System.IntPtr R_ParseVector(System.IntPtr statement, int statementCount, out RDotNet.Internals.ParseStatus status, System.IntPtr _) {
			var function = this.dll.GetFunction<_R_ParseVector>("R_ParseVector");
			return function(  statement,   statementCount, out   status,   _);
		}
		
		[System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		delegate System.IntPtr _Rf_findVar(System.IntPtr name, System.IntPtr environment);
		
		public System.IntPtr Rf_findVar(System.IntPtr name, System.IntPtr environment) {
			var function = this.dll.GetFunction<_Rf_findVar>("Rf_findVar");
			return function(  name,   environment);
		}
		
		[System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		delegate void _Rf_setVar(System.IntPtr name, System.IntPtr value, System.IntPtr environment);
		
		public void Rf_setVar(System.IntPtr name, System.IntPtr value, System.IntPtr environment) {
			var function = this.dll.GetFunction<_Rf_setVar>("Rf_setVar");
			function(  name,   value,   environment);
		}
		
		[System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		delegate System.IntPtr _Rf_getAttrib(System.IntPtr sexp, System.IntPtr name);
		
		public System.IntPtr Rf_getAttrib(System.IntPtr sexp, System.IntPtr name) {
			var function = this.dll.GetFunction<_Rf_getAttrib>("Rf_getAttrib");
			return function(  sexp,   name);
		}
		
		[System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		delegate System.IntPtr _Rf_setAttrib(System.IntPtr sexp, System.IntPtr name, System.IntPtr value);
		
		public System.IntPtr Rf_setAttrib(System.IntPtr sexp, System.IntPtr name, System.IntPtr value) {
			var function = this.dll.GetFunction<_Rf_setAttrib>("Rf_setAttrib");
			return function(  sexp,   name,   value);
		}
		
		[System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		delegate bool _Rf_isEnvironment(System.IntPtr sexp);
		
		public bool Rf_isEnvironment(System.IntPtr sexp) {
			var function = this.dll.GetFunction<_Rf_isEnvironment>("Rf_isEnvironment");
			return function(  sexp);
		}
		
		[System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		delegate bool _Rf_isExpression(System.IntPtr sexp);
		
		public bool Rf_isExpression(System.IntPtr sexp) {
			var function = this.dll.GetFunction<_Rf_isExpression>("Rf_isExpression");
			return function(  sexp);
		}
		
		[System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		delegate bool _Rf_isSymbol(System.IntPtr sexp);
		
		public bool Rf_isSymbol(System.IntPtr sexp) {
			var function = this.dll.GetFunction<_Rf_isSymbol>("Rf_isSymbol");
			return function(  sexp);
		}
	}
}
