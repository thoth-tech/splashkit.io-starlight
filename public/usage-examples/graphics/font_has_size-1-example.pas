program FontHasSizeExample;
uses
  splashkit, sysutils;

var
  fontName: string;
  requiredSize: integer;
  hasSizeByName, hasSizeByObject: boolean;
  myFont: Font;
begin
  fontName := 'Arial';
  requiredSize := 12;

  // Check using the overload that takes a font name.
  hasSizeByName := font_has_size(fontName, requiredSize);

  // Load a Font object with the required size.
  myFont := load_font('Arial', 'arial.ttf', 12);
  hasSizeByObject := font_has_size(myFont, requiredSize);

  writeln('Checking font using font name overload:');
  writeln('Font ', fontName, ' with size ', requiredSize, ': ', 
    ifthen(hasSizeByName, 'Yes', 'No'));

  writeln('Checking font using font object overload:');
  writeln('Font ', myFont.name, ' with size ', requiredSize, ': ', 
    ifthen(hasSizeByObject, 'Yes', 'No'));

  // Keep processing events until the user quits.
  while not quit_requested do
  begin
    process_events;
  end;
end.
