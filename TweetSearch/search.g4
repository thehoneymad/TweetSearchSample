grammar Search;

expr: term (op term)*;
term: EXACTTEXT | hashText | toText | fromText | ID;
op: AND | OR;

toText: 'to:'ID;
fromText: 'from:'ID;
hashText: '#'ID;

// lexer rule
EXACTTEXT: '"' ~'"'* '"';
OR: 'or';
AND: 'and';
ID: [a-zA-Z_] [a-zA-Z0-9_]*;
WS: [ \n\t\r]+ -> skip;