// Generated from c:\Users\swp\Documents\visual studio 2017\Projects\TweetQuery\TweetSearch\search.g4 by ANTLR 4.7
import org.antlr.v4.runtime.Lexer;
import org.antlr.v4.runtime.CharStream;
import org.antlr.v4.runtime.Token;
import org.antlr.v4.runtime.TokenStream;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.misc.*;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class ProfaneLexer extends Lexer {
	static { RuntimeMetaData.checkVersion("4.7", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, ID=6, SMILEY=7, WS=8, PLUS=9, 
		EQUAL=10, ASSIGN=11, NOTEQUAL=12, MINUS=13, GT=14, LT=15, GTEQ=16, LTEQ=17, 
		NUMBER=18, STRING=19;
	public static String[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static String[] modeNames = {
		"DEFAULT_MODE"
	};

	public static final String[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "ID", "SMILEY", "WS", "PLUS", 
		"EQUAL", "ASSIGN", "NOTEQUAL", "MINUS", "GT", "LT", "GTEQ", "LTEQ", "INT", 
		"NUMBER", "STRING"
	};

	private static final String[] _LITERAL_NAMES = {
		null, "'dump'", "'derp'", "'???'", "'yep ->'", "'kbye'", null, "':)'", 
		null, "'+'", "'===='", "'='", "'!!=='", "'-'", "'>'", "'<'"
	};
	private static final String[] _SYMBOLIC_NAMES = {
		null, null, null, null, null, null, "ID", "SMILEY", "WS", "PLUS", "EQUAL", 
		"ASSIGN", "NOTEQUAL", "MINUS", "GT", "LT", "GTEQ", "LTEQ", "NUMBER", "STRING"
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


	public ProfaneLexer(CharStream input) {
		super(input);
		_interp = new LexerATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	@Override
	public String getGrammarFileName() { return "search.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public String[] getChannelNames() { return channelNames; }

	@Override
	public String[] getModeNames() { return modeNames; }

	@Override
	public ATN getATN() { return _ATN; }

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\2\25\u0085\b\1\4\2"+
		"\t\2\4\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4"+
		"\13\t\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\4\21\t\21\4\22"+
		"\t\22\4\23\t\23\4\24\t\24\4\25\t\25\3\2\3\2\3\2\3\2\3\2\3\3\3\3\3\3\3"+
		"\3\3\3\3\4\3\4\3\4\3\4\3\5\3\5\3\5\3\5\3\5\3\5\3\5\3\6\3\6\3\6\3\6\3\6"+
		"\3\7\3\7\7\7H\n\7\f\7\16\7K\13\7\3\b\3\b\3\b\3\t\6\tQ\n\t\r\t\16\tR\3"+
		"\t\3\t\3\n\3\n\3\13\3\13\3\13\3\13\3\13\3\f\3\f\3\r\3\r\3\r\3\r\3\r\3"+
		"\16\3\16\3\17\3\17\3\20\3\20\3\21\3\21\3\21\3\22\3\22\3\22\3\23\6\23r"+
		"\n\23\r\23\16\23s\3\24\3\24\3\24\5\24y\n\24\5\24{\n\24\3\25\3\25\7\25"+
		"\177\n\25\f\25\16\25\u0082\13\25\3\25\3\25\2\2\26\3\3\5\4\7\5\t\6\13\7"+
		"\r\b\17\t\21\n\23\13\25\f\27\r\31\16\33\17\35\20\37\21!\22#\23%\2\'\24"+
		")\25\3\2\7\5\2C\\aac|\6\2\62;C\\aac|\5\2\13\f\17\17\"\"\3\2\62;\4\2\f"+
		"\f$$\2\u0089\2\3\3\2\2\2\2\5\3\2\2\2\2\7\3\2\2\2\2\t\3\2\2\2\2\13\3\2"+
		"\2\2\2\r\3\2\2\2\2\17\3\2\2\2\2\21\3\2\2\2\2\23\3\2\2\2\2\25\3\2\2\2\2"+
		"\27\3\2\2\2\2\31\3\2\2\2\2\33\3\2\2\2\2\35\3\2\2\2\2\37\3\2\2\2\2!\3\2"+
		"\2\2\2#\3\2\2\2\2\'\3\2\2\2\2)\3\2\2\2\3+\3\2\2\2\5\60\3\2\2\2\7\65\3"+
		"\2\2\2\t9\3\2\2\2\13@\3\2\2\2\rE\3\2\2\2\17L\3\2\2\2\21P\3\2\2\2\23V\3"+
		"\2\2\2\25X\3\2\2\2\27]\3\2\2\2\31_\3\2\2\2\33d\3\2\2\2\35f\3\2\2\2\37"+
		"h\3\2\2\2!j\3\2\2\2#m\3\2\2\2%q\3\2\2\2\'u\3\2\2\2)|\3\2\2\2+,\7f\2\2"+
		",-\7w\2\2-.\7o\2\2./\7r\2\2/\4\3\2\2\2\60\61\7f\2\2\61\62\7g\2\2\62\63"+
		"\7t\2\2\63\64\7r\2\2\64\6\3\2\2\2\65\66\7A\2\2\66\67\7A\2\2\678\7A\2\2"+
		"8\b\3\2\2\29:\7{\2\2:;\7g\2\2;<\7r\2\2<=\7\"\2\2=>\7/\2\2>?\7@\2\2?\n"+
		"\3\2\2\2@A\7m\2\2AB\7d\2\2BC\7{\2\2CD\7g\2\2D\f\3\2\2\2EI\t\2\2\2FH\t"+
		"\3\2\2GF\3\2\2\2HK\3\2\2\2IG\3\2\2\2IJ\3\2\2\2J\16\3\2\2\2KI\3\2\2\2L"+
		"M\7<\2\2MN\7+\2\2N\20\3\2\2\2OQ\t\4\2\2PO\3\2\2\2QR\3\2\2\2RP\3\2\2\2"+
		"RS\3\2\2\2ST\3\2\2\2TU\b\t\2\2U\22\3\2\2\2VW\7-\2\2W\24\3\2\2\2XY\7?\2"+
		"\2YZ\7?\2\2Z[\7?\2\2[\\\7?\2\2\\\26\3\2\2\2]^\7?\2\2^\30\3\2\2\2_`\7#"+
		"\2\2`a\7#\2\2ab\7?\2\2bc\7?\2\2c\32\3\2\2\2de\7/\2\2e\34\3\2\2\2fg\7@"+
		"\2\2g\36\3\2\2\2hi\7>\2\2i \3\2\2\2jk\7@\2\2kl\7?\2\2l\"\3\2\2\2mn\7@"+
		"\2\2no\7?\2\2o$\3\2\2\2pr\t\5\2\2qp\3\2\2\2rs\3\2\2\2sq\3\2\2\2st\3\2"+
		"\2\2t&\3\2\2\2uz\5%\23\2vx\7\60\2\2wy\5%\23\2xw\3\2\2\2xy\3\2\2\2y{\3"+
		"\2\2\2zv\3\2\2\2z{\3\2\2\2{(\3\2\2\2|\u0080\7$\2\2}\177\n\6\2\2~}\3\2"+
		"\2\2\177\u0082\3\2\2\2\u0080~\3\2\2\2\u0080\u0081\3\2\2\2\u0081\u0083"+
		"\3\2\2\2\u0082\u0080\3\2\2\2\u0083\u0084\7$\2\2\u0084*\3\2\2\2\t\2IRs"+
		"xz\u0080\3\b\2\2";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}