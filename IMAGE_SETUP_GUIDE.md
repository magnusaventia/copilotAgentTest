# ??? How to Add Images to Your Municipal Quiz

## Current Status ?
The quiz application is now ready to display contextual images for each question! Currently, when images are not found, the app gracefully handles this by hiding the image area and continuing with the quiz.

## Adding Real Images ??

### Step 1: Obtain Images
Collect 30 high-quality images related to Norwegian municipalities. Here are the specific images needed:

**Geography Questions:**
- `kautokeino_landscape.jpg` - Vast landscape of Kautokeino
- `nordkapp_cliff.jpg` - The dramatic North Cape
- `utsira_island.jpg` - Small island of Utsira
- `lindesnes_lighthouse.jpg` - Southernmost point lighthouse
- `lofoten_islands.jpg` - Dramatic Lofoten archipelago
- `roros_mountains.jpg` - High-altitude mountain town
- `tromso_coastline.jpg` - Complex coastal geography

**Cities & Population:**
- `oslo_city.jpg` - Norway's capital and largest city
- `bergen_harbor.jpg` - Historic harbor city
- `small_village.jpg` - Tiny Norwegian village
- `baerum_houses.jpg` - Affluent residential area

**Infrastructure & Transport:**
- `bergen_tunnel.jpg` - Mountain tunnels
- `bodo_train_station.jpg` - Northernmost railway station
- `wind_turbines.jpg` - Renewable energy infrastructure

**Culture & History:**
- `trondheim_cathedral.jpg` - Former capital's cathedral
- `hammerfest_lights.jpg` - Historic electric lighting
- `sami_culture.jpg` - Indigenous Sami culture
- `roros_museum.jpg` - UNESCO World Heritage mining town

**Government & Politics:**
- `norway_map.jpg` - Administrative map
- `norway_regions.jpg` - Regional divisions
- `municipal_building.jpg` - Local government building
- `municipal_reform.jpg` - Reform infographic
- `mayor_office.jpg` - Municipal leadership

**Economy & Tourism:**
- `fishing_fleet.jpg` - Maritime industry
- `geiranger_hotels.jpg` - Tourism infrastructure
- `ntnu_campus.jpg` - Education sector

**Climate & Nature:**
- `rainy_western_norway.jpg` - West coast weather
- `midnight_sun.jpg` - Arctic phenomenon
- `stavanger_climate.jpg` - Mild coastal climate
- `ski_trails.jpg` - Winter recreation

### Step 2: Image Specifications
- **Format**: JPG or PNG
- **Resolution**: 800x600 pixels recommended
- **Aspect Ratio**: 4:3 or 16:9 works best
- **File Size**: Keep under 500KB for optimal performance
- **Quality**: Clear and high-contrast for easy viewing

### Step 3: Installation
1. Place your images in the `Images/` folder
2. Use the exact filenames listed above
3. The quiz will automatically load them when questions appear

### Step 4: Testing
- Run the quiz and verify images display correctly
- Images should appear above each question
- If an image fails to load, the quiz continues normally

## Source Suggestions ??

### Free Image Sources:
- **Unsplash.com** - High-quality Norway photography
- **Pixabay.com** - Free Norwegian municipality images
- **Norwegian Tourism Board** - Official tourism photos
- **Wikimedia Commons** - Public domain Norwegian images
- **Visit Norway** - Official tourism imagery

### Search Terms:
- "Norway municipalities"
- "Norwegian cities aerial view"
- "Norwegian landscapes"
- "Nordic architecture"
- "Scandinavian nature"
- "[Municipality name] Norway"

## Legal Considerations ??
- Ensure you have rights to use the images
- Check licensing requirements
- Consider using Creative Commons licensed images
- Give proper attribution if required

## Fallback Behavior ???
The application includes robust error handling:
- Missing images won't crash the quiz
- Image area will be hidden if loading fails
- Quiz continues normally without images
- No user intervention required

Your municipal quiz is now enhanced with visual context that will make learning about Norwegian municipalities much more engaging! ????