{
  description = "A very basic flake";

  inputs = {
    nixpkgs.url = "github:nixos/nixpkgs?ref=nixos-unstable";
  };

  outputs = { self, nixpkgs }: 
  let 
    inherit (nixpkgs) lib;
    forAllSystems = lib.genAttrs lib.systems.flakeExposed;
  in 
  {
    devShells = forAllSystems (
      system:
      let
        pkgs = nixpkgs.legacyPackages.${system};
      in 
      {
        default = pkgs.mkShell {
          buildInputs =[ 
            pkgs.dotnet-sdk_9
          ];
          DOTNET_ROOT = "${pkgs.dotnet-sdk_9}/share/dotnet";
          LD_LIBRARY_PATH = pkgs.lib.makeLibraryPath [
            # may be needed
            #
            # pkgs.freetype
            # pkgs.libGLU
            # pkgs.SDL2
            # pkgs.glfw
            # pkgs.pulseaudio
            # pkgs.xorg.libX11
            # pkgs.xorg.libXrandr
            # pkgs.gtk3
            # pkgs.gtk3-x11

            # required to run on wayland
            pkgs.libGL
            pkgs.libxkbcommon
            pkgs.wayland
            pkgs.dotnet-sdk_9
          ];
        };
      }
    );
  };
}
