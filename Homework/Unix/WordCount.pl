use strict;
use warnings;
package Counter;
sub new{
	my $class 	= shift;
	my $self	= {};
	bless $self,$class;
	return $self;
}
sub add{

	my ($self, $var) = @_;
	if($var eq ""){
		return;
	}
	if(exists($self->{lc $var})){
		$self->{lc $var}+=1;
	}
	else{
		$self->{lc $var}=1;
	}
}
sub getCount{
	my ($self, $var)=@_;
	if(exists($self->{lc $var})){
		return $self->{lc $var};
	}
	else{
		return 0;
	}
}
sub sortunits{
	my ($self)=@_;
	foreach my $unit (sort{$self->{$b} <=> $self->{$a} } keys%$self){
		print $unit,"\t",$self->{$unit},"\n";
	}
}
package Manager;
sub new{
	my $class= shift;
	my $self= { _file=>shift, _dictionary=>undef, _alphabet=>undef};
	bless $self, $class;
	$self->iterate();
	$self->display();
	return $self;
}
sub iterate{
	my ($self)=@_;
	$self->{_dictionary}= new Counter();
	$self->{_alphabet}= new Counter();
	open(my $fh, $self->{_file});
	while(my $line = <$fh>){
		chomp $line;
		my @words = split / |\,|\.|\@|\||[0-9]|\-/, $line;
		for my $words (@words){

			$self->{_dictionary}->add($words);
			my @characters = split //, $words;
			for my $char (@characters){
				$self->{_alphabet}->add($char);
			}
		}
	}
}
sub display{
	my ($self) = @_;
	print "-------Letters sorted in order of frequency------------\n\n\n";
	$self->{_alphabet}->sortunits();
	print "-------------------------------------------------------\n";
	print "-------Words sorted in order of frequency------------\n\n\n";

	$self->{_dictionary}->sortunits();
}
new Manager("hwCheck-input.txt");
