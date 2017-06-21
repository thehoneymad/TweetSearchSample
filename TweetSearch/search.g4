grammar Search;

searchUnit: term| expr;

defaultOp: word*;
exactText: '"' word* '"';
hashText: '#'word;
toText: 'to:'word;
fromText: 'from:'word;

term: defaultOp | exactText | hashText | toText | fromText;

expr: term (op term)+;

op: AND | OR;
word: ID;

// constants
ID: [a-zA-Z_] [a-zA-Z0-9_]*;
OR: 'OR';
AND: 'AND';

WS: [ \n\t\r]+ -> skip;