//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Search.g4 by ANTLR 4.7

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public partial class SearchParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, EXACTTEXT=4, OR=5, AND=6, ID=7, WS=8;
	public const int
		RULE_expr = 0, RULE_term = 1, RULE_op = 2, RULE_toText = 3, RULE_fromText = 4, 
		RULE_hashText = 5, RULE_exactText = 6;
	public static readonly string[] ruleNames = {
		"expr", "term", "op", "toText", "fromText", "hashText", "exactText"
	};

	private static readonly string[] _LiteralNames = {
		null, "'to:'", "'from:'", "'#'", null, "'OR'", "'AND'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, "EXACTTEXT", "OR", "AND", "ID", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Search.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static SearchParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public SearchParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public SearchParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}
	public partial class ExprContext : ParserRuleContext {
		public TermContext[] term() {
			return GetRuleContexts<TermContext>();
		}
		public TermContext term(int i) {
			return GetRuleContext<TermContext>(i);
		}
		public OpContext[] op() {
			return GetRuleContexts<OpContext>();
		}
		public OpContext op(int i) {
			return GetRuleContext<OpContext>(i);
		}
		public ExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expr; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISearchListener typedListener = listener as ISearchListener;
			if (typedListener != null) typedListener.EnterExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISearchListener typedListener = listener as ISearchListener;
			if (typedListener != null) typedListener.ExitExpr(this);
		}
	}

	[RuleVersion(0)]
	public ExprContext expr() {
		ExprContext _localctx = new ExprContext(Context, State);
		EnterRule(_localctx, 0, RULE_expr);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 14; term();
			State = 20;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==OR || _la==AND) {
				{
				{
				State = 15; op();
				State = 16; term();
				}
				}
				State = 22;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TermContext : ParserRuleContext {
		public ExactTextContext exactText() {
			return GetRuleContext<ExactTextContext>(0);
		}
		public HashTextContext hashText() {
			return GetRuleContext<HashTextContext>(0);
		}
		public ToTextContext toText() {
			return GetRuleContext<ToTextContext>(0);
		}
		public FromTextContext fromText() {
			return GetRuleContext<FromTextContext>(0);
		}
		public TermContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_term; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISearchListener typedListener = listener as ISearchListener;
			if (typedListener != null) typedListener.EnterTerm(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISearchListener typedListener = listener as ISearchListener;
			if (typedListener != null) typedListener.ExitTerm(this);
		}
	}

	[RuleVersion(0)]
	public TermContext term() {
		TermContext _localctx = new TermContext(Context, State);
		EnterRule(_localctx, 2, RULE_term);
		try {
			State = 27;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case EXACTTEXT:
				EnterOuterAlt(_localctx, 1);
				{
				State = 23; exactText();
				}
				break;
			case T__2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 24; hashText();
				}
				break;
			case T__0:
				EnterOuterAlt(_localctx, 3);
				{
				State = 25; toText();
				}
				break;
			case T__1:
				EnterOuterAlt(_localctx, 4);
				{
				State = 26; fromText();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class OpContext : ParserRuleContext {
		public ITerminalNode AND() { return GetToken(SearchParser.AND, 0); }
		public ITerminalNode OR() { return GetToken(SearchParser.OR, 0); }
		public OpContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_op; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISearchListener typedListener = listener as ISearchListener;
			if (typedListener != null) typedListener.EnterOp(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISearchListener typedListener = listener as ISearchListener;
			if (typedListener != null) typedListener.ExitOp(this);
		}
	}

	[RuleVersion(0)]
	public OpContext op() {
		OpContext _localctx = new OpContext(Context, State);
		EnterRule(_localctx, 4, RULE_op);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 29;
			_la = TokenStream.LA(1);
			if ( !(_la==OR || _la==AND) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ToTextContext : ParserRuleContext {
		public ITerminalNode ID() { return GetToken(SearchParser.ID, 0); }
		public ToTextContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_toText; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISearchListener typedListener = listener as ISearchListener;
			if (typedListener != null) typedListener.EnterToText(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISearchListener typedListener = listener as ISearchListener;
			if (typedListener != null) typedListener.ExitToText(this);
		}
	}

	[RuleVersion(0)]
	public ToTextContext toText() {
		ToTextContext _localctx = new ToTextContext(Context, State);
		EnterRule(_localctx, 6, RULE_toText);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 31; Match(T__0);
			State = 32; Match(ID);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class FromTextContext : ParserRuleContext {
		public ITerminalNode ID() { return GetToken(SearchParser.ID, 0); }
		public FromTextContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_fromText; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISearchListener typedListener = listener as ISearchListener;
			if (typedListener != null) typedListener.EnterFromText(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISearchListener typedListener = listener as ISearchListener;
			if (typedListener != null) typedListener.ExitFromText(this);
		}
	}

	[RuleVersion(0)]
	public FromTextContext fromText() {
		FromTextContext _localctx = new FromTextContext(Context, State);
		EnterRule(_localctx, 8, RULE_fromText);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 34; Match(T__1);
			State = 35; Match(ID);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class HashTextContext : ParserRuleContext {
		public ITerminalNode ID() { return GetToken(SearchParser.ID, 0); }
		public HashTextContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_hashText; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISearchListener typedListener = listener as ISearchListener;
			if (typedListener != null) typedListener.EnterHashText(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISearchListener typedListener = listener as ISearchListener;
			if (typedListener != null) typedListener.ExitHashText(this);
		}
	}

	[RuleVersion(0)]
	public HashTextContext hashText() {
		HashTextContext _localctx = new HashTextContext(Context, State);
		EnterRule(_localctx, 10, RULE_hashText);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 37; Match(T__2);
			State = 38; Match(ID);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExactTextContext : ParserRuleContext {
		public ITerminalNode EXACTTEXT() { return GetToken(SearchParser.EXACTTEXT, 0); }
		public ExactTextContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_exactText; } }
		public override void EnterRule(IParseTreeListener listener) {
			ISearchListener typedListener = listener as ISearchListener;
			if (typedListener != null) typedListener.EnterExactText(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ISearchListener typedListener = listener as ISearchListener;
			if (typedListener != null) typedListener.ExitExactText(this);
		}
	}

	[RuleVersion(0)]
	public ExactTextContext exactText() {
		ExactTextContext _localctx = new ExactTextContext(Context, State);
		EnterRule(_localctx, 12, RULE_exactText);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 40; Match(EXACTTEXT);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\n', '-', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', '\t', 
		'\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', '\x6', 
		'\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', '\b', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\a', '\x2', '\x15', 
		'\n', '\x2', '\f', '\x2', '\xE', '\x2', '\x18', '\v', '\x2', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x5', '\x3', '\x1E', '\n', 
		'\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', 
		'\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x2', '\x2', '\t', 
		'\x2', '\x4', '\x6', '\b', '\n', '\f', '\xE', '\x2', '\x3', '\x3', '\x2', 
		'\a', '\b', '\x2', ')', '\x2', '\x10', '\x3', '\x2', '\x2', '\x2', '\x4', 
		'\x1D', '\x3', '\x2', '\x2', '\x2', '\x6', '\x1F', '\x3', '\x2', '\x2', 
		'\x2', '\b', '!', '\x3', '\x2', '\x2', '\x2', '\n', '$', '\x3', '\x2', 
		'\x2', '\x2', '\f', '\'', '\x3', '\x2', '\x2', '\x2', '\xE', '*', '\x3', 
		'\x2', '\x2', '\x2', '\x10', '\x16', '\x5', '\x4', '\x3', '\x2', '\x11', 
		'\x12', '\x5', '\x6', '\x4', '\x2', '\x12', '\x13', '\x5', '\x4', '\x3', 
		'\x2', '\x13', '\x15', '\x3', '\x2', '\x2', '\x2', '\x14', '\x11', '\x3', 
		'\x2', '\x2', '\x2', '\x15', '\x18', '\x3', '\x2', '\x2', '\x2', '\x16', 
		'\x14', '\x3', '\x2', '\x2', '\x2', '\x16', '\x17', '\x3', '\x2', '\x2', 
		'\x2', '\x17', '\x3', '\x3', '\x2', '\x2', '\x2', '\x18', '\x16', '\x3', 
		'\x2', '\x2', '\x2', '\x19', '\x1E', '\x5', '\xE', '\b', '\x2', '\x1A', 
		'\x1E', '\x5', '\f', '\a', '\x2', '\x1B', '\x1E', '\x5', '\b', '\x5', 
		'\x2', '\x1C', '\x1E', '\x5', '\n', '\x6', '\x2', '\x1D', '\x19', '\x3', 
		'\x2', '\x2', '\x2', '\x1D', '\x1A', '\x3', '\x2', '\x2', '\x2', '\x1D', 
		'\x1B', '\x3', '\x2', '\x2', '\x2', '\x1D', '\x1C', '\x3', '\x2', '\x2', 
		'\x2', '\x1E', '\x5', '\x3', '\x2', '\x2', '\x2', '\x1F', ' ', '\t', '\x2', 
		'\x2', '\x2', ' ', '\a', '\x3', '\x2', '\x2', '\x2', '!', '\"', '\a', 
		'\x3', '\x2', '\x2', '\"', '#', '\a', '\t', '\x2', '\x2', '#', '\t', '\x3', 
		'\x2', '\x2', '\x2', '$', '%', '\a', '\x4', '\x2', '\x2', '%', '&', '\a', 
		'\t', '\x2', '\x2', '&', '\v', '\x3', '\x2', '\x2', '\x2', '\'', '(', 
		'\a', '\x5', '\x2', '\x2', '(', ')', '\a', '\t', '\x2', '\x2', ')', '\r', 
		'\x3', '\x2', '\x2', '\x2', '*', '+', '\a', '\x6', '\x2', '\x2', '+', 
		'\xF', '\x3', '\x2', '\x2', '\x2', '\x4', '\x16', '\x1D',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
