package Person;
sub new{
	my $class = shift;
	my $self = {
		_record				=>	shift,
		"First Name"		=>	undef,
		"Last Name"			=>	undef,
		"Address"			=>	undef,
		"City"				=>	undef,
		"State"				=>	undef,
		"Zip Code"			=>	undef,
		"Phone Number"		=>	undef,
		"Email Address"		=>	undef,
		_problems			=>	[],
		_regexps			=>	["([A-Z]|' '|'\'')([a-z]|' '|'\'')*","([A-Z]|' '|'\'')([a-z]|' '|'\'')*","([0-9])+\ [A-Z][a-z]*\ (St\.|Rd\.|Dr\.|Cir\.|Ln\.|Blvd\.)","[A-Z]([a-z]|[A-Z]|\.|\ )*","[A-Z]{2}","[0-9]{5}\-?[0-9]{0,4}?",'\([0-9]{3}\)\ [0-9]{3}\-[0-9]{4}',"([A-Z] | [a-z] | [0-9])*\@([A-Z] | [a-z])*\.([A-Z] | [a-z])*"],
	};
	bless $self, $class;
	$self->splitRecords();
	$self->check();
	return $self;

}
sub splitRecords{
	my ($self) = @_;
	chomp $self->{_record};
	($self->{"First Name"}, $self->{"Last Name"}, $self->{"Address"},$self->{"City"},$self->{"State"},$self->{"Zip Code"},$self->{"Phone Number"},$self->{"Email Address"})= 
		split(/\|/, $self->{_record});
}
sub getProblems{
	my		($self)= @_;
	if(scalar @{$self->{_problems}}==0){
		return 0;
	}
	else{
		return $self->{_problems};
	}
}
sub getRecord{
	my		($self)=@_;
	return $self->{_record};
}
sub getName{
	my	($self)=@_;
	return "$self->{'First Name'} $self->{'Last Name'}";
}
sub check{
	my	($self)		=	@_;
	my	@arr		=	@ {$self->{_regexps}};				#	Dereference with @ {}
	if(!defined($self->{"Email Address"})){
		$self->{_problems}=["Not Enough Values. Please Check Input"];
		return;
	}
	if(!(($self->{"First Name"})=~$arr[0])){
		push(@{$self->{_problems}}, "First Name");
	}
	if(!(($self->{"Last Name"})=~$arr[1])){
		push(@{$self->{_problems}}, "Last Name");
	}
	if(!(($self->{"Address"})=~$arr[2])){
		push(@{$self->{_problems}}, "Address");
	}
	if(!(($self->{"City"})=~$arr[3])){
		push(@{$self->{_problems}}, "City");
	}
	if(!(($self->{"State"})=~$arr[4])){
		push(@{$self->{_problems}}, "State");
	}
	if(!(($self->{"Zip Code"})=~$arr[5])){
		push(@{$self->{_problems}}, "Zip Code");
	}
	if(!(($self->{"Phone Number"})=~$arr[6])){
		# print $self->{"Phone Number"};
		push(@{$self->{_problems}}, "Phone Number");
	}
	if(!(($self->{"Email Address"})=~$arr[7])){
		push(@{$self->{_problems}}, "Email Address");
	}
	if(!defined($self->{"Email Address"})){
		$self->{_problems}=["Not Enough Values. Please Check Input"];
	}
}
1;
package Manager;
sub new{
	my $class= shift;
	my $self= {
		_file	=> shift,
		_valid => [],
		_invalid => [],
	};
	bless $self, $class;
	$self->readEntries();
	$self->writefiles();
	return $self;
} 
sub croak{
	die "$0: @_: $!\n"
}
sub readEntries{
	my ($self) = @_;
	open(my $fh, $self->{_file});
	while(	my $line	=	<$fh>	){
		$entry =  new Person($line);
		$problems = $entry->getProblems();
		$name= $entry->getName();
		if($problems==0){
			push($self->{_valid}, $entry);
			print "The entry for $name is valid!\n";
		}
		else{
			$grammarhelper=0;
			print "The Entry For $name has the following problems: ";
			for $prob (@{$problems}){
			if($grammarhelper==0){		print "$prob is invalid"; }
			else{print ", $prob is invalid";}
			$grammarhelper+=1;
		}
		print ".\n";
		push($self->{_invalid}, $entry)
		}
	}
	close $fh;
}

sub writefiles{
	my ($self) = @_;
	open(my $fh, '>'."valid.txt");
	for $entry (@{$self->{_valid}}){
		print $fh $entry->getRecord(),"\n";
	}
	close $fh;
	open(my $fh, '>'."invalid.txt");
	for $entry (@{$self->{_invalid}}){
		print $fh $entry->getRecord(),"\n";
	}
	close $fh;
}
1;

# Object Orientation
$object = new Manager("hwCheck-input.txt");
