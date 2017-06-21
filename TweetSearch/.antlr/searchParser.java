// Generated from c:\Users\swp\Documents\visual studio 2017\Projects\TweetQuery\TweetSearch\search.g4 by ANTLR 4.7
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.misc.*;
import org.antlr.v4.runtime.tree.*;
import java.util.List;
import java.util.Iterator;
import java.util.ArrayList;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class searchParser extends Parser {
	static { RuntimeMetaData.checkVersion("4.7", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__0=1, T__1=2, T__2=3, T__3=4, ID=5, OR=6, AND=7, WS=8;
	public static final int
		RULE_searchUnit = 0, RULE_defaultOp = 1, RULE_exactText = 2, RULE_hashText = 3, 
		RULE_toText = 4, RULE_fromText = 5, RULE_term = 6, RULE_expr = 7, RULE_op = 8, 
		RULE_word = 9;
	public static final String[] ruleNames = {
		"searchUnit", "defaultOp", "exactText", "hashText", "toText", "fromText", 
		"term", "expr", "op", "word"
	};

	private static final String[] _LITERAL_NAMES = {
		null, "'\"'", "'#'", "'to:'", "'from:'", null, "'OR'", "'AND'"
	};
	private static final String[] _SYMBOLIC_NAMES = {
		null, null, null, null, null, "ID", "OR", "AND", "WS"
	};
	public static final Vocabulary VOCABULARY = new VocabularyImpl(_LITERAL_NAMES, _SYMBOLIC_NAMES);

	/**
	 * @deprecated Use {@link #VOCABULARY} instead.
	 */
	@Deprecated
	public static final String[] tokenNames;
	static {
		tokenNames = new String[_SYMBOLIC_NAMES.length];
		for (int i = 0; i < tokenNames.length; i++) {
			tokenNames[i] = VOCABULARY.getLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = VOCABULARY.getSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}
	}

	@Override
	@Deprecated
	public String[] getTokenNames() {
		return tokenNames;
	}

	@Override

	public Vocabulary getVocabulary() {
		return VOCABULARY;
	}

	@Override
	public String getGrammarFileName() { return "search.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public ATN getATN() { return _ATN; }

	public searchParser(TokenStream input) {
		super(input);
		_interp = new ParserATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}
	public static class SearchUnitContext extends ParserRuleContext {
		public TermContext term() {
			return getRuleContext(TermContext.class,0);
		}
		public ExprContext expr() {
			return getRuleContext(ExprContext.class,0);
		}
		public SearchUnitContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_searchUnit; }
	}

	public final SearchUnitContext searchUnit() throws RecognitionException {
		SearchUnitContext _localctx = new SearchUnitContext(_ctx, getState());
		enterRule(_localctx, 0, RULE_searchUnit);
		try {
			setState(22);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,0,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(20);
				term();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(21);
				expr();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class DefaultOpContext extends ParserRuleContext {
		public List<WordContext> word() {
			return getRuleContexts(WordContext.class);
		}
		public WordContext word(int i) {
			return getRuleContext(WordContext.class,i);
		}
		public DefaultOpContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_defaultOp; }
	}

	public final DefaultOpContext defaultOp() throws RecognitionException {
		DefaultOpContext _localctx = new DefaultOpContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_defaultOp);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(27);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while (_la==ID) {
				{
				{
				setState(24);
				word();
				}
				}
				setState(29);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ExactTextContext extends ParserRuleContext {
		public List<WordContext> word() {
			return getRuleContexts(WordContext.class);
		}
		public WordContext word(int i) {
			return getRuleContext(WordContext.class,i);
		}
		public ExactTextContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_exactText; }
	}

	public final ExactTextContext exactText() throws RecognitionException {
		ExactTextContext _localctx = new ExactTextContext(_ctx, getState());
		enterRule(_localctx, 4, RULE_exactText);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(30);
			match(T__0);
			setState(34);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while (_la==ID) {
				{
				{
				setState(31);
				word();
				}
				}
				setState(36);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(37);
			match(T__0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class HashTextContext extends ParserRuleContext {
		public WordContext word() {
			return getRuleContext(WordContext.class,0);
		}
		public HashTextContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_hashText; }
	}

	public final HashTextContext hashText() throws RecognitionException {
		HashTextContext _localctx = new HashTextContext(_ctx, getState());
		enterRule(_localctx, 6, RULE_hashText);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(39);
			match(T__1);
			setState(40);
			word();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ToTextContext extends ParserRuleContext {
		public WordContext word() {
			return getRuleContext(WordContext.class,0);
		}
		public ToTextContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_toText; }
	}

	public final ToTextContext toText() throws RecognitionException {
		ToTextContext _localctx = new ToTextContext(_ctx, getState());
		enterRule(_localctx, 8, RULE_toText);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(42);
			match(T__2);
			setState(43);
			word();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class FromTextContext extends ParserRuleContext {
		public WordContext word() {
			return getRuleContext(WordContext.class,0);
		}
		public FromTextContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_fromText; }
	}

	public final FromTextContext fromText() throws RecognitionException {
		FromTextContext _localctx = new FromTextContext(_ctx, getState());
		enterRule(_localctx, 10, RULE_fromText);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(45);
			match(T__3);
			setState(46);
			word();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class TermContext extends ParserRuleContext {
		public DefaultOpContext defaultOp() {
			return getRuleContext(DefaultOpContext.class,0);
		}
		public ExactTextContext exactText() {
			return getRuleContext(ExactTextContext.class,0);
		}
		public HashTextContext hashText() {
			return getRuleContext(HashTextContext.class,0);
		}
		public ToTextContext toText() {
			return getRuleContext(ToTextContext.class,0);
		}
		public FromTextContext fromText() {
			return getRuleContext(FromTextContext.class,0);
		}
		public TermContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_term; }
	}

	public final TermContext term() throws RecognitionException {
		TermContext _localctx = new TermContext(_ctx, getState());
		enterRule(_localctx, 12, RULE_term);
		try {
			setState(53);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case EOF:
			case ID:
			case OR:
			case AND:
				enterOuterAlt(_localctx, 1);
				{
				setState(48);
				defaultOp();
				}
				break;
			case T__0:
				enterOuterAlt(_localctx, 2);
				{
				setState(49);
				exactText();
				}
				break;
			case T__1:
				enterOuterAlt(_localctx, 3);
				{
				setState(50);
				hashText();
				}
				break;
			case T__2:
				enterOuterAlt(_localctx, 4);
				{
				setState(51);
				toText();
				}
				break;
			case T__3:
				enterOuterAlt(_localctx, 5);
				{
				setState(52);
				fromText();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ExprContext extends ParserRuleContext {
		public List<TermContext> term() {
			return getRuleContexts(TermContext.class);
		}
		public TermContext term(int i) {
			return getRuleContext(TermContext.class,i);
		}
		public List<OpContext> op() {
			return getRuleContexts(OpContext.class);
		}
		public OpContext op(int i) {
			return getRuleContext(OpContext.class,i);
		}
		public ExprContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_expr; }
	}

	public final ExprContext expr() throws RecognitionException {
		ExprContext _localctx = new ExprContext(_ctx, getState());
		enterRule(_localctx, 14, RULE_expr);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(55);
			term();
			setState(59); 
			_errHandler.sync(this);
			_la = _input.LA(1);
			do {
				{
				{
				setState(56);
				op();
				setState(57);
				term();
				}
				}
				setState(61); 
				_errHandler.sync(this);
				_la = _input.LA(1);
			} while ( _la==OR || _la==AND );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class OpContext extends ParserRuleContext {
		public TerminalNode AND() { return getToken(searchParser.AND, 0); }
		public TerminalNode OR() { return getToken(searchParser.OR, 0); }
		public OpContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_op; }
	}

	public final OpContext op() throws RecognitionException {
		OpContext _localctx = new OpContext(_ctx, getState());
		enterRule(_localctx, 16, RULE_op);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(63);
			_la = _input.LA(1);
			if ( !(_la==OR || _la==AND) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class WordContext extends ParserRuleContext {
		public TerminalNode ID() { return getToken(searchParser.ID, 0); }
		public WordContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_word; }
	}

	public final WordContext word() throws RecognitionException {
		WordContext _localctx = new WordContext(_ctx, getState());
		enterRule(_localctx, 18, RULE_word);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(65);
			match(ID);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\3\nF\4\2\t\2\4\3\t"+
		"\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4\13\t\13\3"+
		"\2\3\2\5\2\31\n\2\3\3\7\3\34\n\3\f\3\16\3\37\13\3\3\4\3\4\7\4#\n\4\f\4"+
		"\16\4&\13\4\3\4\3\4\3\5\3\5\3\5\3\6\3\6\3\6\3\7\3\7\3\7\3\b\3\b\3\b\3"+
		"\b\3\b\5\b8\n\b\3\t\3\t\3\t\3\t\6\t>\n\t\r\t\16\t?\3\n\3\n\3\13\3\13\3"+
		"\13\2\2\f\2\4\6\b\n\f\16\20\22\24\2\3\3\2\b\t\2C\2\30\3\2\2\2\4\35\3\2"+
		"\2\2\6 \3\2\2\2\b)\3\2\2\2\n,\3\2\2\2\f/\3\2\2\2\16\67\3\2\2\2\209\3\2"+
		"\2\2\22A\3\2\2\2\24C\3\2\2\2\26\31\5\16\b\2\27\31\5\20\t\2\30\26\3\2\2"+
		"\2\30\27\3\2\2\2\31\3\3\2\2\2\32\34\5\24\13\2\33\32\3\2\2\2\34\37\3\2"+
		"\2\2\35\33\3\2\2\2\35\36\3\2\2\2\36\5\3\2\2\2\37\35\3\2\2\2 $\7\3\2\2"+
		"!#\5\24\13\2\"!\3\2\2\2#&\3\2\2\2$\"\3\2\2\2$%\3\2\2\2%\'\3\2\2\2&$\3"+
		"\2\2\2\'(\7\3\2\2(\7\3\2\2\2)*\7\4\2\2*+\5\24\13\2+\t\3\2\2\2,-\7\5\2"+
		"\2-.\5\24\13\2.\13\3\2\2\2/\60\7\6\2\2\60\61\5\24\13\2\61\r\3\2\2\2\62"+
		"8\5\4\3\2\638\5\6\4\2\648\5\b\5\2\658\5\n\6\2\668\5\f\7\2\67\62\3\2\2"+
		"\2\67\63\3\2\2\2\67\64\3\2\2\2\67\65\3\2\2\2\67\66\3\2\2\28\17\3\2\2\2"+
		"9=\5\16\b\2:;\5\22\n\2;<\5\16\b\2<>\3\2\2\2=:\3\2\2\2>?\3\2\2\2?=\3\2"+
		"\2\2?@\3\2\2\2@\21\3\2\2\2AB\t\2\2\2B\23\3\2\2\2CD\7\7\2\2D\25\3\2\2\2"+
		"\7\30\35$\67?";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}